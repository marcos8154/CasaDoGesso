using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace DAL
{
    public class ParameterRebinder : ExpressionVisitor
    {
        private readonly Dictionary<ParameterExpression, ParameterExpression> map;

        public ParameterRebinder(Dictionary<ParameterExpression, ParameterExpression> map)
        {
            this.map = map ?? new Dictionary<ParameterExpression, ParameterExpression>();
        }

        public static Expression ReplaceParameters(Dictionary<ParameterExpression, ParameterExpression> map, Expression exp)
        {
            return new ParameterRebinder(map).Visit(exp);
        }

        protected override Expression VisitParameter(ParameterExpression p)
        {
            ParameterExpression replacement;
            if (map.TryGetValue(p, out replacement))
                p = replacement;

            return base.VisitParameter(p);
        }
    }

    public static class DALExtensions
    {
        public static object CopyFrom(this object target, object source)
        {
            foreach (PropertyInfo pInfo in source.GetType().GetProperties())
                target.GetType().GetProperty(pInfo.Name)
                    .SetValue(target, pInfo.GetValue(source, null), null);

            return target;
        }


        // O método EscreverExtenso recebe um valor do tipo decimal
        public static string EscreverExtenso(decimal valor)
        {
            if (valor <= 0 | valor >= 1000000000000000)
                return "Valor não suportado pelo sistema.";
            else
            {
                string strValor = valor.ToString("000000000000000.00");
                string valor_por_extenso = string.Empty;
                for (int i = 0; i <= 15; i += 3)
                {
                    valor_por_extenso += Escrever_Valor_Extenso(Convert.ToDecimal(strValor.Substring(i, 3)));
                    if (i == 0 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(0, 3)) == 1)
                            valor_por_extenso += " TRILHÃO" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0) ? " E " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(0, 3)) > 1)
                            valor_por_extenso += " TRILHÕES" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0) ? " E " : string.Empty);
                    }
                    else if (i == 3 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(3, 3)) == 1)
                            valor_por_extenso += " BILHÃO" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " E " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(3, 3)) > 1)
                            valor_por_extenso += " BILHÕES" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " E " : string.Empty);
                    }
                    else if (i == 6 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(6, 3)) == 1)
                            valor_por_extenso += " MILHÃO" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " E " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(6, 3)) > 1)
                            valor_por_extenso += " MILHÕES" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " E " : string.Empty);
                    }
                    else if (i == 9 & valor_por_extenso != string.Empty)
                        if (Convert.ToInt32(strValor.Substring(9, 3)) > 0)
                            valor_por_extenso += " MIL" + ((Convert.ToDecimal(strValor.Substring(12, 3)) > 0) ? " E " : string.Empty);
                    if (i == 12)
                    {
                        if (valor_por_extenso.Length > 8)
                            if (valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "BILHÃO" | valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "MILHÃO")
                                valor_por_extenso += " DE";
                            else
                                if (valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "BILHÕES" | valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "MILHÕES"
| valor_por_extenso.Substring(valor_por_extenso.Length - 8, 7) == "TRILHÕES")
                                valor_por_extenso += " DE";
                            else
                                    if (valor_por_extenso.Substring(valor_por_extenso.Length - 8, 8) == "TRILHÕES")
                                valor_por_extenso += " DE";
                        if (Convert.ToInt64(strValor.Substring(0, 15)) == 1)
                            valor_por_extenso += " REAL";
                        else if (Convert.ToInt64(strValor.Substring(0, 15)) > 1)
                            valor_por_extenso += " REAIS";
                        if (Convert.ToInt32(strValor.Substring(16, 2)) > 0 && valor_por_extenso != string.Empty)
                            valor_por_extenso += " E ";
                    }
                    if (i == 15)
                        if (Convert.ToInt32(strValor.Substring(16, 2)) == 1)
                            valor_por_extenso += " CENTAVO";
                        else if (Convert.ToInt32(strValor.Substring(16, 2)) > 1)
                            valor_por_extenso += " CENTAVOS";
                }
                return valor_por_extenso;
            }
        }
        static string Escrever_Valor_Extenso(decimal valor)
        {
            if (valor <= 0)
                return string.Empty;
            else
            {
                string montagem = string.Empty;
                if (valor > 0 & valor < 1)
                {
                    valor *= 100;
                }
                string strValor = valor.ToString("000");
                int a = Convert.ToInt32(strValor.Substring(0, 1));
                int b = Convert.ToInt32(strValor.Substring(1, 1));
                int c = Convert.ToInt32(strValor.Substring(2, 1));
                if (a == 1) montagem += (b + c == 0) ? "CEM" : "CENTO";
                else if (a == 2) montagem += "DUZENTOS";
                else if (a == 3) montagem += "TREZENTOS";
                else if (a == 4) montagem += "QUATROCENTOS";
                else if (a == 5) montagem += "QUINHENTOS";
                else if (a == 6) montagem += "SEISCENTOS";
                else if (a == 7) montagem += "SETECENTOS";
                else if (a == 8) montagem += "OITOCENTOS";
                else if (a == 9) montagem += "NOVECENTOS";
                if (b == 1)
                {
                    if (c == 0) montagem += ((a > 0) ? " E " : string.Empty) + "DEZ";
                    else if (c == 1) montagem += ((a > 0) ? " E " : string.Empty) + "ONZE";
                    else if (c == 2) montagem += ((a > 0) ? " E " : string.Empty) + "DOZE";
                    else if (c == 3) montagem += ((a > 0) ? " E " : string.Empty) + "TREZE";
                    else if (c == 4) montagem += ((a > 0) ? " E " : string.Empty) + "QUATORZE";
                    else if (c == 5) montagem += ((a > 0) ? " E " : string.Empty) + "QUINZE";
                    else if (c == 6) montagem += ((a > 0) ? " E " : string.Empty) + "DEZESSEIS";
                    else if (c == 7) montagem += ((a > 0) ? " E " : string.Empty) + "DEZESSETE";
                    else if (c == 8) montagem += ((a > 0) ? " E " : string.Empty) + "DEZOITO";
                    else if (c == 9) montagem += ((a > 0) ? " E " : string.Empty) + "DEZENOVE";
                }
                else if (b == 2) montagem += ((a > 0) ? " E " : string.Empty) + "VINTE";
                else if (b == 3) montagem += ((a > 0) ? " E " : string.Empty) + "TRINTA";
                else if (b == 4) montagem += ((a > 0) ? " E " : string.Empty) + "QUARENTA";
                else if (b == 5) montagem += ((a > 0) ? " E " : string.Empty) + "CINQUENTA";
                else if (b == 6) montagem += ((a > 0) ? " E " : string.Empty) + "SESSENTA";
                else if (b == 7) montagem += ((a > 0) ? " E " : string.Empty) + "SETENTA";
                else if (b == 8) montagem += ((a > 0) ? " E " : string.Empty) + "OITENTA";
                else if (b == 9) montagem += ((a > 0) ? " E " : string.Empty) + "NOVENTA";
                if (strValor.Substring(1, 1) != "1" & c != 0 & montagem != string.Empty) montagem += " E ";
                if (strValor.Substring(1, 1) != "1")
                    if (c == 1) montagem += "UM";
                    else if (c == 2) montagem += "DOIS";
                    else if (c == 3) montagem += "TRÊS";
                    else if (c == 4) montagem += "QUATRO";
                    else if (c == 5) montagem += "CINCO";
                    else if (c == 6) montagem += "SEIS";
                    else if (c == 7) montagem += "SETE";
                    else if (c == 8) montagem += "OITO";
                    else if (c == 9) montagem += "NOVE";
                return montagem;
            }
        }


        public static string CompactarString(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            byte[] buffer = Encoding.UTF8.GetBytes(text);
            MemoryStream ms = new MemoryStream();
            using (GZipStream zip = new GZipStream(ms, CompressionMode.Compress, true))
            {
                zip.Write(buffer, 0, buffer.Length);
            }

            ms.Position = 0;
            MemoryStream outStream = new MemoryStream();

            byte[] compressed = new byte[ms.Length];
            ms.Read(compressed, 0, compressed.Length);

            byte[] gzBuffer = new byte[compressed.Length + 4];
            System.Buffer.BlockCopy(compressed, 0, gzBuffer, 4, compressed.Length);
            System.Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gzBuffer, 0, 4);
            return Convert.ToBase64String(gzBuffer);
        }

        public static string RemoverCaracteres(this string text)
        {
            return (text
                .Trim()
                .TrimStart()
                .TrimEnd()
                .Replace(".", string.Empty)
                .Replace("-", string.Empty)
                .Replace(",", string.Empty)
                .Replace("/", string.Empty)
                .Replace(@"\", string.Empty)
                .Replace("_", string.Empty)
                .Replace("ç", "c")
                .Replace("Ç", "C")
                .Replace("ã", "a")
                .Replace("Ã", "A")
                .Replace("õ", "o")
                .Replace("Õ", "O")
                .Replace("ó", "o")
                .Replace("Ó", "O")
                .Replace("é", "e")
                .Replace("É", "E")
                .Replace("í", "i")
                .Replace("Í", "I")
                .Replace("á", "A")
                .Replace("è", "e")
                .Replace("à", "a")
                .Replace("À", "A")
                .Replace("Â", "A")
                .Replace("â", "a")
                .Replace("(", string.Empty)
                .Replace(")", string.Empty));
        }

        /*
        public static void MudarFocoComEnter(this KeyEventArgs e)
        {
            var elemento = e.OriginalSource as System.Windows.UIElement;
            if (elemento == null)
                return;
            if (e.Key == Key.Enter)
                elemento.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
        }
        */

        public static string DescompactarString(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            try
            {
                byte[] gzBuffer = Convert.FromBase64String(text);
                using (MemoryStream ms = new MemoryStream())
                {
                    int msgLength = BitConverter.ToInt32(gzBuffer, 0);
                    ms.Write(gzBuffer, 4, gzBuffer.Length - 4);

                    byte[] buffer = new byte[msgLength];

                    ms.Position = 0;
                    using (GZipStream zip = new GZipStream(ms, CompressionMode.Decompress))
                    {
                        zip.Read(buffer, 0, buffer.Length);
                    }
                    return Encoding.UTF8.GetString(buffer);
                }
            }
            catch { return text; }
        }



        static string[] indicadores = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z 1 2 3 4 5 6 7 8 9 0 ! @ # $ % ¨& * ( ) - +  / =".Split(' ');
        static List<string[]> paginas = new List<string[]>();
        static List<KeyValuePair<string, int>> indice = new List<KeyValuePair<string, int>>();

        public static void IndexarIBGE()
        {
            if (IBGE == null)
                IBGE = File.ReadAllLines(@".\IBGE.txt");

            string[] dados = IBGE;

            for (int i = 0; i < indicadores.Length; i++)
            {
                string letraInicial = indicadores[i];
                if (string.IsNullOrEmpty(letraInicial))
                    continue;

                string[] palavras = dados.Where(d => d.ToLower().StartsWith(letraInicial.ToLower())).Distinct().ToArray();
                if (palavras.Length == 0)
                    continue;

                paginas.Add(palavras);
                int indx = indice.Count;
                indice.Add(new KeyValuePair<string, int>(letraInicial, indx));
            }
        }

        private static string Buscar(string municipio, string uf)
        {
            List<string> result = new List<string>();

            char letra = municipio.FirstOrDefault();
            int indicePagina = indice.FirstOrDefault(e =>
                e.Key.ToLower().Equals(letra.ToString().ToLower())).Value;

            string[] paginaDados = paginas[indicePagina];

            foreach (string palavra in paginaDados)
            {
                var p = palavra.ToLower();
                var i = municipio.ToLower();

                if (ForcarComparacao(p, i))
                    result.Add(palavra);
            }

            var mun = result.FirstOrDefault(e => e.Contains(uf));
            return (string.IsNullOrEmpty(mun)
                ? string.Empty
                : mun.Split('\t')[2]);
        }

        private static bool ForcarComparacao(string munTxt, string munUsr)
        {
            int total = munUsr.Length;
            decimal expected = ((decimal)munUsr.Length / 100 * 85);
            decimal accerted = 0;

            for (int i = 0; i < munUsr.Length; i++)
            {
                if (munTxt.Length <= i)
                    break;

                if (munTxt[i] == munUsr[i])
                    accerted++;
            }

            bool result = (accerted >= expected);
            return result;
        }

        private static string[] IBGE { get; set; }

        public static string BuscaIBGE(string municipio, string uf)
        {
            return Buscar(municipio, uf);
        }


        public static Expression<T> Compose<T>(this Expression<T> first, Expression<T> second, Func<Expression, Expression, Expression> merge)
        {
            // build parameter map (from parameters of second to parameters of first)
            var map = first.Parameters.Select((f, i) => new { f, s = second.Parameters[i] }).ToDictionary(p => p.s, p => p.f);

            // replace parameters in the second lambda expression with parameters from the first
            var secondBody = ParameterRebinder.ReplaceParameters(map, second.Body);

            // apply composition of lambda expression bodies to parameters from the first expression 
            return Expression.Lambda<T>(merge(first.Body, secondBody), first.Parameters);
        }

        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
        {
            return first.Compose(second, Expression.And);
        }

        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
        {
            return first.Compose(second, Expression.Or);
        }
    }
}
