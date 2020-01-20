LINK PARA O POWERPOINT
https://docs.google.com/presentation/d/1077y3RJ8tuaWZuZ-BdUEyOTOFOD79zgBESiJIwSJZ4Q/edit#slide=id.g6c3177c2a0_1_13
EXERCICIOS
Ingresso
	Lista todos os ingressos cadastrados

	Ingresso?dataInicio=2019-12-09&dataFim=2019-12-09&cpf=26555333057&sessao=4
	Lista os ingressos utilizando filtros opcionais para os seguintes campos:
		DataCompra
		CPF
		CodigoSessao

Sessao
	Cadastrar uma sessão com os seguintes requisitos:
		O código deve ser único
		Uma sessão não pode ter uma Sala que já está sendo utilizada nesse período

Sessao/{codigo}
	Buscar uma Sessão pelo seu código cadastrado
	Caso não exista nenhuma sessão com esse código retornar 404 (Not Found)
	

Sugestões:
	Sigam os exemplos dos Endpoints Existentes 
	O Projeto esta divido da seguinte forma:
		Api  
		Application
		Infra.EF
	A Camada de API é a porta de entrada para acesso as informações
	A camada de Application tem todas a regras de negócio e manipulação dos objetos
	A camada de Infra.EF é responsável apenas pelo acesso aos dados

	Todas as camadas devem conter algum código
	Deve-se respeitar a estrutura do programa
	
	Todas as camadas devem ser utilizadas para a construção 
	O banco de dados esta rodando em um Docker (SQL) e ele ja tem alguns filmes cadastrados
	Para acesso ao banco caso seja necessário podera utilizar o DBeaver https://dbeaver.io/download/
	Todas as bases ja estão criadas e pré carregadas
	Rodar o Programa F5, Buildar o Programa CTRL+SHIFT+B, no Output voce consegue ver os erros
	Caso queira debugar basta colocar um BreakPoint na linha e rodar através do F5 ou apertar o Play
	no VSCode

	Qualquer dúvida é só chamar!




docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong@Passw0rd" \
-p 1433:1433 --name MyDb \
-d mcr.microsoft.com/mssql/server:2019-GA-ubuntu-16.04;

