# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Gerenciar um condomínio residencial é, por muitas vezes, um problemas aos síndicos e empresas gestoras de condomínio. Diante o exposto, esse projeto tem como ponto central a criação de uma ferramenta que auxilie na gestão de condomínios. O programa de software criado, se propõe a ajudar otimizando a comunicação e a interação entre moradores, porteiro e síndico, por meio de alertas, agendamentos online e disponibilização de documentos aos moradores. 
O desenvolvimento da problematização é baseada a partir das experiências empíricas dos membros dessa equipe, que em maioria, são moradores de condomínios residenciais e vivenciam essas falhas na comunicação,o que fragiliza a gestão do condomínio. 
Diante o exposto, toda a evolução das etapas de trabalho é pautada na abstração de um problema apresentado no mundo real e trabalhada em uma solução de software.


## Personas
As personas levantadas durante o processo de entendimento do problema são apresentadas na Figuras que se seguem.


1. Jorge Severino de Jesus
Idade: 72
Ocupação: porteiro, encanador, eletricista, motorista de  aplicativo e visagista de vitrine de calçados.
Aplicativos: Instagram, whatsapp, twitter. Motivações: trabalha para sustentar 5 filhos, Gosta de dar informação em primeira mão. 
Frustrações: Não ter terminado o curso de astrofísica pelo instituto universal brasileiro
ter perdido R$ 2.894,26 em aplicação de bitcoin.
Hobbies, História: Possui um canal no youtube que se chama “notícias do forno”, Atua como detetive particular e gosta de usar sua caneta espiã.

2. Alberto Roberto
Idade: 68
Ocupação: Aposentado e síndico do Condomínio Moradas da Formosura.  
Aplicativos: Facebook, Instagram, Aplicativos de bancos. Motivações: Atento às inovações tecnológicas, estar sendo útil às pessoas
Frustrações: Não ter emplacado como jogador do madureira, ter abandonado a faculdade de ciência de dados.
Hobbies, História: jogar truco, ir aos desfiles das escolas de samba e jogar futebol com os amigos.

3. Eduardo Costa
Idade: 39
Ocupação: Médico, investidor na bolsa de valores no tempo livre e  Morador do Condomínio moradas da formosa
Aplicativos: Snapchat, Instagram, Aplicativos de bancos, FaceTime, Investidora XP.
Frustrações: Não ter encontrado uma esposa para compartilhar sua vida; Ter perdido 35% de seu dinheiro em ações mal estruturadas; Não ter aproveitado mais a vida na juventude.
Hobbies, História: Leitura nos tempos vagos;, Investimento em ações; Viajar o mundo; Está fazendo seu próprio livro sobre sua especialização médica.







Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Eu, Alberto Roberto, como síndico do condomínio realizo a gestão de 10 andares com 2 apartamentos por andar e gostaria de ter maior comunicação e capilaridade no momento de contactar os moradores do prédio  |Desejo ter um jeito de comunicar todos os moradores de uma só vez quanto às decisões e as ocorrências acontecidas no condomínio          |Para que as comunicações e decisões possam chegar a todos os moradores o mais rápido possível evitando surpresas e aumentando a satisfação do coletivo               |
|Eu, Jorge Severino de Jesus, como porteiro do condomínio, tenho que receber itens e correspondência dos moradores que às vezes não estão em casa       |Desejo ter um meio de comunicar com o morador mesmo quando ele não está em casa e saber onde ele está e que horas vai chegar.                 |Para que eu possa informar os moradores das suas encomendas e deixá-los ciente para pegá-las no escaninho mesmo quando eu não estiver na portaria ou ser avisado imediatamente assim que acontecer alguma emergência. e poder ajudar e fazer contato com a família caso seja necessário. |
|Eu, Eduardo Costa, como morador do condomínio, tenho que deixar marcado muito antes quando vou receber visitas, sendo que muitas delas não é uma coisa combinada de semanas atrás por assim dizer, ou quando peço um delivery e gostaria de um meio mais fácil para fazer este tipo de coisa.       |Gostaria de ter um meio de marcar quando vou receber visitas ou receber algum produto sem precisar ter que avisar semanas antes, não tendo muito trabalho e também gostaria de ter uma forma mais fácil de acessar boletos que sejam do condomínio.                 |Para minhas visitas não ficarem esperando muito na portaria por falta de comunicação, para que também seja mais facil o recebimento dos meus pedidos e para facilitar os meios de pagamentos que estão relacionados ao condomínio. |


> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001|O sistema deve permitir o cadastro de usuários e moradias | ALTA | 
|RF-002| O sistema deve permitir o cadastro do usuário proprietário  mediante a validação do usuário master.   | ALTA |
|RF-003| O sistema deve permitir que o usuário master  realize o agendamento de reuniões e que o usuário proprietário receba um alerta de reunião agendada.  | MÉDIA |
|RF-004| O sistema deve permitir que o usuário master  realize o cadastro de ata de reunião e outros documentos de interesse geral e que podem ser visualizados pelos proprietários.   | MÉDIA |
|RF-005| O sistema deve permitir que o usuário porteiro registre o recebimento de encomendas para moradia específica e armazene uma foto da encomenda.  | MÉDIA |
|RF-006| O sistema de alerta deve emitir um alerta ao usuário proprietário toda vez que for registrado uma encomenda para sua moradia e que o usuário porteiro registre o recebimento da encomenda pelo usuário proprietário.   | MÉDIA |
|RF-007| O sistema deve permitir que o usuário master realize o cadastro de áreas comuns.   | BAIXA |
|RF-008| O sistema deve permitir que o usuário proprietário solicite o uso de áreas comuns por meio de reservas de uso a serem aprovadas pelo usuário master reservas de áreas comuns do condomínio   | BAIXA |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve possuir interface em nas plataformas Web, IOs e Android. | ALTA | 
|RNF-002| Usuários sem permissão de administrador não podem ter acesso a dados de outros usuários. |  ALTA | 
|RNF-003| O sistema deve ser fácil de usar e intuitivo, com uma interface amigável e bem projetada. |  MEDIA |
|RNF-004| O sistema deve estar de acordo com o código civil brasileiro e com LGPD. |  BAIXA |
|RNF-005| O sistema deve ser seguro para proteger as informações do condomínio contra acessos não autorizados. |  ALTA |
|RNF-006| O sistema deve ter os perfis de acesso bem definidos em relação às permissões e proibições para impedir acessos à informações e funcionalidades. |  MEDIA |

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 19/06/2023. |
|RE-02| O sistema deve se restringir às tecnologias básicas da Web no Back-end.        |
|RE-03|A equipe não pode subcontratar o desenvolvimento do trabalho. |


## Diagrama de Casos de Uso

O diagrama contempla as principais ligações previstas entre casos de uso e atores e permite detalhar os Requisitos Funcionais identificados na etapa de elicitação. Ressaltamos que, para os requisitos não funcionais, não será utilizado diagrama de caso de uso.  

![Exemplo de Caso de Uso](img/cadastrar_usuario_moradia.png)
![Exemplo de Caso de Uso](img/receber_mercadorias.png)
![Exemplo de Caso de Uso](img/cadastrar_areacomum.png)
![Exemplo de Caso de Uso](img/cadastrar_documenotos.png)
![Exemplo de Caso de Uso](img/cadastrar_reuniões.png)
![Exemplo de Caso de Uso](img/cadastrar_usuario_moradia.png)

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
