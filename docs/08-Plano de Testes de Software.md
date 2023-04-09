# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.



| ID        | Funcionalidade (teste usuário) |Entrada de funcionalidade (como executar)             |Saída esperada |Registro de teste (o que aconteceu descrição) |Evidência |
|-----------|------------------------------------|----------------------|--------------|----------------|-------------------|
|RF-01    |Cadastro de moradias         | Com o usuário master já logado, na página principal, será possível acessar o menu cadastros/moradia e realizar cadastro da moradia.              | Cadastro da moradia realizado com sucesso||||
|RF-01 |Cadastro de moradias          |Caso o usuário logado seja diferente de master o menu cadastros não será apresentado.                | Menu de cadastro de moradias não será apresentado. ||||
|RF-01 |Cadastro de usuários          |Com o usuário master já logado, na página principal, será possível acessar o menu cadastros/usuários e realizar cadastro de usuários.                | Cadastro de usuário realizado com sucesso. ||||
|RF-01	 |Cadastro de usuários          |Cadastro de usuário realizado com sucesso.              | Menu de cadastro de usuário não será apresentado.  ||||
|RF-02  |Validação de cadastro          |Com o usuário master já logado, será possível validar uma auto cadastro do usuário proprietário.                | Cadastro validado com sucesso. ||||
|RF-02  |Validação de cadastro         |Caso o usuário logado seja diferente de master não será apresentada a opção de validar cadastro.              | Solicitação de validação não será apresentado ||||
|RF-02  |Auto cadastro do usuário proprietário.           |O usuário poderá preencher o menu de cadastro do tipo proprietário para posterior validação pelo usuário master.                | Solicitação de cadastro de proprietário enviada com sucesso para validação. ||||
|RF- 03  |Agendamento de reuniões          |Com o usuário master logado, será possível agendar o menu de reuniões e realizar o agendamento.              | Agendamento de reunião realizado com sucesso. ||||
|RF- 03  |Agendamento de reuniões         |Caso o usuário logado seja diferente do usuário master não será exibido o menu de agendamento de reuniões.                | Menu de agendamento de reuniões não será exibido.  ||||
|RF- 03 |Alerta de reuniões           |O usuário proprietário deve receber uma alerta toda vez que uma reunião for agendada               | Alerta de reunião enviados aos usuários proprietários ||||
|RF- 04 |Cadastro de documentos/ ata de reuniões.           |Com o usuário master logado, será possível acessar o menu reunião e cadastrar documentos/ ata relacionados.                | Cadastro de Documentos/ata da reunião realizados com sucesso.  ||||
|RF- 04 |Cadastro de documentos/ ata de reuniões.          |Caso o usuário logado não seja do tipo master não será possível acessar o menu reunião e cadastrar documentos/ ata relacionados.                | Menu reunião não será apresentado.  ||||
|RF- 04 |Visualização de documentos cadastrados          |Com o usuário proprietário logado será possível ter acesso ao menu documentos cadastrados.                | Menu de documentos cadastrados será exibido.||||
|RF- 04 |Visualização de documentos cadastrados          |Caso o usuário proprietário não esteja logado não será possível ter acesso ao menu documentos cadastrados.               | Menu de documentos cadastrados não será exibido. ||||
|RF-05  |Registro de recebimento de encomendas           |Com o usuário porteiro logado, será possível acessar o menu recebimento de encomenda, registrá-la e associá-la à moradia específica               | Menu recebimento será exibido.  ||||
|RF-05  |Registro de recebimento de encomendas          |Caso o usuário porteiro não esteja logado, não será possível acessar o menu recebimento.                | Menu recebimento não será exibido.  ||||
|RF-05  |Armazenamento de foto da encomenda recebida           |Com o usuário porteiro logado, após o registro de encomenda e associação à moradia específica será apresentado o botão para armazenamento de foto.               | Botão para armazenar foto será exibido.  ||||
|RF-05  |Armazenamento de foto da encomenda recebida           |Com o usuário porteiro logado, caso não seja feito o registro de encomenda e associação à moradia específica não será apresentado o botão para armazenamento de foto.               | Botão para armazenar foto não será exibido.  |||||
|RF-06      |O usuário proprietário deve receber um alerta toda vez que uma encomenda for registrada à sua moradia associada.                | Alerta de encomenda recebida enviada ao usuário proprietário.  |Alerta de encomenda recebida  |||
|RF-07  |Cadastro de áreas comuns          |Com o usuário master logado, será apresentado o menu áreas comuns.               | Área comum cadastrada com sucesso.||||
|RF-07  |Cadastro de áreas comuns          |Caso o usuário logado seja diferente de master o menu área comum não será apresentado.                 | Menu área comum não será apresentado.  ||||
|RF-08 |Solicitação de reserva de área comum          |Com o usuário proprietário logado será possível cadastrar um pedido de reserva de área comum.               | Reserva de área comum foi solicitada com sucesso. Aguarde aprovação.  ||||
|RF-08 |Solicitação de reserva de área comum          |Caso o usuário proprietário não esteja logado não será possível cadastrar um pedido de reserva de área comum.               | Menu de reserva de área comum não será apresentado.  ||||	
|RF-08 |Aprovação de reserva de área comum           |Com o usuário master logado, será possível aprovar ou recusar reserva de área comum.               | Solicitação de reserva foi aprovada ou recusada.  ||||
|RF-08 |Aprovação de reserva de área comum          |Caso o usuário logado seja diferente de master, não será possível aprovar ou recusar reserva de área comum.                | Solicitação de aprovação de reserva não será exibida. ||||



 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
