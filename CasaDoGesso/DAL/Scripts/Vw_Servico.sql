create view Vw_Servico as
(
	select
		Servico.Id,
		Cliente.Nome as Cliente,
		Servico.ClienteId,
		Servico.Data,
		Servico.Observacoes,
		Sum(ItemServico.Total) as Valor
	from Servico
	join Cliente on Servico.ClienteId = Cliente.Id
	join ItemServico on Servico.Id = ItemServico.ServicoId

	group by 
	Servico.Id,
	Cliente.Nome,
	Servico.ClienteId,
	Servico.Data,
	Servico.Observacoes
)