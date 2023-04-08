
# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

3. Metodologia

A metodologia contempla as definições de ferramental utilizado pela equipe tanto para a manutenção dos códigos e demais artefatos quanto para a organização do time na execução das tarefas do projeto.

## Relação de Ambientes de Trabalho


Os artefatos do projeto são desenvolvidos a partir de diversas plataformas e a relação dos ambientes com seu respectivo propósito é apresentada na tabela que se segue.  

Ambiente  |Plataforma  | Link de Acesso|
|------|-----------------------------------------|----|
|Repositório de código fonte|GitHub | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t3-pmv-ads-2023-1-e3-proj-int-t3-time3-ci| 
|Documentos do projeto|Google Drive | https://drive.google.com/drive/u/1/folders/195grl54t2GMdTbW6Zq-yvgbFsO1S_rWc |
|Projeto de Interface e  Wireframes|O sistema deve permitir o cadastro de usuários e moradias | ALTA |
|Gerenciamento do Projeto|GitHub | https://github.com/orgs/ICEI-PUC-Minas-PMV-ADS/projects/284 |

		 
## Gerenciamento do Projeto


- A equipe utiliza metodologias ágeis, tendo escolhido o Scrum como base para definição do processo de desenvolvimento./


A equipe está organizada da seguinte maneira:


- Scrum Master: Jonathan Costa
- Product Owner: Talita Pereira
- Equipe de Desenvolvimento
- Renato Freitas
- Renner Júnior

  Equipe de Design
  
- Nayara de Araújo

- A organização e distribuição das tarefas do projeto se dará por meio de reuniões de Sprints com apoio da organização em quadro Kanban armazenado eletronicamente no site do GitHub Project.  Deste modo, cada membro do time, será responsável por atualizar o status da sua tarefa. A seguir, é apresentado os conceitos metodológicos para o andamento das atividades:  



> - Backlog: recebe as tarefas a serem trabalhadas e representa o Product Backlog. Todas as atividades identificadas no decorrer do projeto também devem ser incorporadas a esta lista.


> - To Do: apresenta a lista de atividades identificadas e priorizadas pela equipe de desenvolvimento. Nela, apresenta todas as funcionalidades apresentadas pelo Product Backlog.


> - Doing: Quando uma tarefa tiver sido iniciada, ela é movida para cá. Esta lista representa quais as atividades estão sendo realizadas, de acordo com a Sprint determinada para o desenvolvimento. Apresentando uma cópia fiel do que está sendo trabalhado.


> - Done: nesta lista são colocadas as tarefas que passaram pelos testes e controle de qualidade e estão prontos para serem entregues ao usuário. Não há mais edições ou revisões necessárias, a tarefa está pronta.


- A funcionalidade de quadro Kanban disponível na ferramenta do GitHUb foi utilizada pelo grupo como ferramenta de gerenciamento de projetos e está disponível através da URL Quadro de Gerenciamento de Projetos e é apresentado, no estado atual, na Figura 1. 

![Exemplo de Caso de Uso](img/quadro_gerenciamento_projetos.png)

## Projeto de Interface


Dentre as preocupações para a montagem da interface do sistema, estamos estabelecendo foco em questões como agilidade, acessibilidade e usabilidade. Desta forma, o projeto tem uma identidade visual padronizada em todas as telas que são projetadas para funcionamento na web e em dispositivos móveis.

- Fluxo do Usuário
- 
O diagrama apresentado na Figura 2 mostra o fluxo de interação do usuário com o sistema.

## Wireframes


Conforme fluxo de telas do projeto, apresentado no item anterior, as telas do sistema são apresentadas em detalhes. As telas do sistema apresentam uma estrutura comum que é apresentada na Figura 3. Nesta estrutura, existem 4 blocos, descritos a seguir. São eles:


## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `unstable`: versão já testada do software, porém instável
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

Discuta como a configuração do projeto foi feita na ferramenta de versionamento escolhida. Exponha como a gerência de tags, merges, commits e branchs é realizada. Discuta como a gerência de issues foi realizada.

> **Links Úteis**:
> - [Tutorial GitHub](https://guides.github.com/activities/hello-world/)
> - [Git e Github](https://www.youtube.com/playlist?list=PLHz_AreHm4dm7ZULPAmadvNhH6vk9oNZA)
>  - [Comparando fluxos de trabalho](https://www.atlassian.com/br/git/tutorials/comparing-workflows)
> - [Understanding the GitHub flow](https://guides.github.com/introduction/flow/)
> - [The gitflow workflow - in less than 5 mins](https://www.youtube.com/watch?v=1SXpE08hvGs)

## Gerenciamento de Projeto

### Divisão de Papéis

Apresente a divisão de papéis entre os membros do grupo.

> **Links Úteis**:
> - [11 Passos Essenciais para Implantar Scrum no seu 
> Projeto](https://mindmaster.com.br/scrum-11-passos/)
> - [Scrum em 9 minutos](https://www.youtube.com/watch?v=XfvQWnRgxG0)

### Processo

Coloque  informações sobre detalhes da implementação do Scrum seguido pelo grupo. O grupo poderá fazer uso de ferramentas on-line para acompanhar o andamento do projeto, a execução das tarefas e o status de desenvolvimento da solução.
 
> **Links Úteis**:
> - [Project management, made simple](https://github.com/features/project-management/)
> - [Sobre quadros de projeto](https://docs.github.com/pt/github/managing-your-work-on-github/about-project-boards)
> - [Como criar Backlogs no Github](https://www.youtube.com/watch?v=RXEy6CFu9Hk)
> - [Tutorial Slack](https://slack.com/intl/en-br/)

### Ferramentas

As ferramentas empregadas no projeto são:

- Editor de código.
- Ferramentas de comunicação
- Ferramentas de desenho de tela (_wireframing_)

O editor de código foi escolhido porque ele possui uma integração com o
sistema de versão. As ferramentas de comunicação utilizadas possuem
integração semelhante e por isso foram selecionadas. Por fim, para criar
diagramas utilizamos essa ferramenta por melhor captar as
necessidades da nossa solução.

Liste quais ferramentas foram empregadas no desenvolvimento do projeto, justificando a escolha delas, sempre que possível.
 
> **Possíveis Ferramentas que auxiliarão no gerenciamento**: 
> - [Slack](https://slack.com/)
> - [Github](https://github.com/)
