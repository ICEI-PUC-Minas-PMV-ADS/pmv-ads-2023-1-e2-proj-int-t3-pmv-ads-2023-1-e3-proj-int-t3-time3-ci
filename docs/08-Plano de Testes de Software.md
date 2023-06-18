# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.



| ID        | Funcionalidade (teste usuário) |Entrada de funcionalidade (como executar)             |Saída esperada |Registro de teste (o que aconteceu descrição) |Evidência |
|-----------|------------------------------------|----------------------|--------------|----------------|-------------------|
|RF-01    |Cadastro de moradias         | Com o usuário master já logado, na página principal, será possível acessar o menu cadastros/moradia e realizar cadastro da moradia.              | Cadastro da moradia realizado com sucesso|Moradia cadastrada com sucesso|![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/6fc6ae2a-83a9-4656-8b1c-4178d41dc6db)
||
|RF-01 |Cadastro de moradias          |Caso o usuário logado seja diferente de master o menu cadastros não será apresentado.                | Menu de cadastro de moradias não será apresentado. |Funcionário comum criador de cadastro de moradia|![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/74f99910-842b-4456-8ede-ae1f63b7e38d)
||
|RF-01 |Cadastro de usuários          |Com o usuário master já logado, na página principal, será possível acessar o menu cadastros/usuários e realizar cadastro de usuários.                | Cadastro de usuário realizado com sucesso. |Cadastro de usuário realizado mesmo sem ser usuário master (síndico)|![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/35d545d2-8058-47cc-a436-7df63ba42a1c)
||
|RF-01	 |Cadastro de usuários          |Cadastro de usuário realizado com sucesso.              | Menu de cadastro de usuário não será apresentado.  |Realizado com sucesso |![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/1f7508f9-4f70-4de6-acdc-897f1ca4d87f)
||
|RF-02  |Validação de cadastro          |Com o usuário master já logado, será possível validar uma auto cadastro do usuário proprietário.                | Cadastro validado com sucesso. |Ainda não há usuário cadastrado /implementado no sistema diverso do usuário master, portanto não há como auto cadastrar|![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/197d18fb-06d2-445b-9af2-9b1af488cd2c)
||
|RF-02  |Validação de cadastro         |Caso o usuário logado seja diferente de master não será apresentada a opção de validar cadastro.              | Solicitação de validação não será apresentado |Ainda não há usuário cadastrado /implementado no sistema diverso do usuário master, portanto não há como validar o cadastro.|![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/cc157f24-6b3d-405d-9898-2fc9b6e84a23)
||
|RF-02  |Auto cadastro do usuário proprietário.           |O usuário poderá preencher o menu de cadastro do tipo proprietário para posterior validação pelo usuário master.                | Solicitação de cadastro de proprietário enviada com sucesso para validação. |Realizado com sucesso|![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/d914e9a3-5d6f-42f0-b7c6-eea8632f2cec)
||
|RF- 03  |Agendamento de reuniões          |Com o usuário master logado, será possível agendar o menu de reuniões e realizar o agendamento.              | Agendamento de reunião realizado com sucesso. |Realizado com sucesso|![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/ea7aa107-66cd-4c0e-9ae6-8d91b6db10a5)
||
|RF- 03  |Agendamento de reuniões         |Caso o usuário logado seja diferente do usuário master não será exibido o menu de agendamento de reuniões.                | Menu de agendamento de reuniões não será exibido.  |Ainda não há usuário cadastrado /implementado no sistema diverso do usuário master, portanto o menu de agendamento sempre é exibido.|![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/3c633cca-22e1-4e19-9eb1-418f9f81e180)
||
|RF- 03 |Alerta de reuniões           |O usuário proprietário deve receber uma alerta toda vez que uma reunião for agendada               | Alerta de reunião enviados aos usuários proprietários |Ainda não há usuário cadastrado /implementado no sistema diverso do usuário master, portanto não é possivel acessar o alerta.|![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/0698b97b-5297-419c-8ce5-26b48b1bc826)
||
|RF- 04 |Cadastro de documentos/ ata de reuniões.           |Com o usuário master logado, será possível acessar o menu reunião e cadastrar documentos/ ata relacionados.                | Cadastro de Documentos/ata da reunião realizados com sucesso.  |É possível acessar o menu, porém não é possível cadastrar documentos.|![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/28eee90c-7c6f-4fb5-9dae-f7791e79cd5d)|
||
|RF- 04 |Cadastro de documentos/ ata de reuniões.          |Caso o usuário logado não seja do tipo master não será possível acessar o menu reunião e cadastrar documentos/ ata relacionados.                | Menu reunião não será apresentado.  |Ainda não há usuário cadastrado /implementado no sistema diverso do usuário master, portanto sempre é possível acessar o menu reunião e cadastrar documentos/ ata relacionados.|![usuario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/ae2cb9f9-85bf-4d74-8edd-b1a00071750c)|
||
|RF- 04 |Visualização de documentos cadastrados          |Com o usuário proprietário logado será possível ter acesso ao menu documentos cadastrados.                | Menu de documentos cadastrados será exibido.|Ainda não há usuário cadastrado /implementado no sistema diverso do usuário master, portanto não é possível verificar o menu de menu documentos cadastrados desta tela|![usuario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/34a2a441-8088-4f18-93c6-94fa87396ecf)|
||
|RF- 04 |Visualização de documentos cadastrados          |Caso o usuário proprietário não esteja logado não será possível ter acesso ao menu documentos cadastrados.               | Menu de documentos cadastrados não será exibido. |Ainda não há usuário cadastrado /implementado no sistema diverso do usuário master, portanto não é possível verificar o menu de menu documentos cadastrados desta tela.|![semusuario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/6452aec7-45d4-440d-87d8-60dc777042f3)|
||
|RF-05  |Registro de recebimento de encomendas           |Com o usuário porteiro logado, será possível acessar o menu recebimento de encomenda, registrá-la e associá-la à moradia específica               | Menu recebimento será exibido.  |Ainda não há usuário cadastrado /implementado no sistema diverso do usuário master, portanto não é possível verificar a encomenda.|![semusuario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/dc2d4699-e4e4-44d6-bb46-81a5711c2a22)|
||
|RF-05  |Registro de recebimento de encomendas          |Caso o usuário porteiro não esteja logado, não será possível acessar o menu recebimento.                | Menu recebimento não será exibido.  |Ainda não há usuário cadastrado /implementado no sistema diverso do usuário master, portanto não é possível verificar o menu de recebimento.|![semusuario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/e50f6816-ee21-47a2-a43c-1bb0147dde87)|
||
|RF-05  |Armazenamento de foto da encomenda recebida           |Com o usuário porteiro logado, após o registro de encomenda e associação à moradia específica será apresentado o botão para armazenamento de foto.               | Botão para armazenar foto será exibido.  |Ainda não há usuário cadastrado /implementado no sistema diverso do usuário master, portanto não é possível verificar o menu de recebimento.|![semusuario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/9dd249b6-5f5e-48f9-97cc-1464374a4d27)
||
|RF-05  |Armazenamento de foto da encomenda recebida           |Com o usuário porteiro logado, caso não seja feito o registro de encomenda e associação à moradia específica não será apresentado o botão para armazenamento de foto.               | Botão para armazenar foto não será exibido.  |Ainda não há usuário cadastrado /implementado no sistema diverso do usuário master, portanto não é possível verificar o botão de armazenamento de foto|![semusuario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/81cb1147-645c-4f0f-ab11-14edd31ed82b)
||
|RF-06      |O usuário proprietário deve receber um alerta toda vez que uma encomenda for registrada à sua moradia associada.                | Alerta de encomenda recebida enviada ao usuário proprietário.  |Alerta de encomenda recebida  |Ainda não há usuário cadastrado /implementado no sistema diverso do usuário master, portanto não é possível verificar o menu de menu documentos cadastrados nesta tela.|![semusuario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/7fe6ebbf-34d8-4bd7-942c-6a7f5c52218d)
||
|RF-07  |Cadastro de áreas comuns          |Com o usuário master logado, será apresentado o menu áreas comuns.               | Área comum cadastrada com sucesso.|Realizado com sucesso|![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/6800bd9f-b054-4847-8a85-5728ffc6efe0)|
||
|RF-07  |Cadastro de áreas comuns          |Caso o usuário logado seja diferente de master o menu área comum não será apresentado.                 | Menu área comum não será apresentado.  |Realizado com sucesso|![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/acc51b76-109c-4b4f-8953-e03693158a0a)|
||
|RF-08 |Solicitação de reserva de área comum          |Com o usuário proprietário logado será possível cadastrar um pedido de reserva de área comum.               | Reserva de área comum foi solicitada com sucesso. Aguarde aprovação.  |Ainda não há usuário cadastrado /implementado no sistema diverso do usuário master, portanto não é possível verificar o menu de menu áreas comuns a solicitação da reserva|![semusuario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/0f775503-df74-4e93-88fd-cb96aa4b54f4)
||
|RF-08 |Solicitação de reserva de área comum          |Caso o usuário proprietário não esteja logado não será possível cadastrar um pedido de reserva de área comum.               | Menu de reserva de área comum não será apresentado.  |Ainda não há usuário cadastrado /implementado no sistema diverso do usuário master, portanto não é possível verificar o menu de menu áreas comuns a solicitação da reserva.|![semusuario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/092bf58b-1f78-45c2-b932-9d1cf9944c4d)
||	
|RF-08 |Aprovação de reserva de área comum           |Com o usuário master logado, será possível aprovar ou recusar reserva de área comum.               | Solicitação de reserva foi aprovada ou recusada.  |Ainda não há usuário cadastrado /implementado no sistema diverso do usuário master, portanto não é possível verificar o menu de menu áreas comuns se a reserva foi aprovada ou recusada.|![semusuario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/af223ab8-fa63-41f0-afea-bbaf9cee409f)
||
|RF-08 |Aprovação de reserva de área comum          |Caso o usuário logado seja diferente de master, não será possível aprovar ou recusar reserva de área comum.                | Solicitação de aprovação de reserva não será exibida. |Ainda não há usuário cadastrado /implementado no sistema diverso do usuário master, portanto não é possível verificar o menu de menu áreas comuns se a reserva foi aprovada ou recusada.|![semusuario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci/assets/86340530/976bed56-dacd-45dd-af14-2c3594d86aa4)
||



 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
