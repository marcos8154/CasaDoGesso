create view Vw_Orcamento as
(
	select
		Orcamento.Id,
		Cliente.Nome as Cliente,
		Orcamento.Data,
		Orcamento.Observacoes,
		
		(case Orcamento.Encerrado
			when 1 then 'Sim'
			else 'Não'
		end) as Encerrado,

		Sum(ItemOrcamento.Total) as Valor
	from Orcamento
	join Cliente on Orcamento.ClienteId = Cliente.Id
	join ItemOrcamento on Orcamento.Id = ItemOrcamento.OrcamentoId

	group by 
	Orcamento.Id,
	Cliente.Nome,
	Orcamento.Data,
	Orcamento.Observacoes, 
	Orcamento.Encerrado
)