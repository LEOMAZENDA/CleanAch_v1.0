Descrição do meu projeto Clean Architecture:

Olá, sou Leonilldo Mazenda e estou desenvolvendo um projeto em Clean Architecture. Acredito que essa abordagem é ideal para criar um software modular e de fácil manutenção. Dividi meu projeto em seis partes, onde cada uma desempenha um papel específico.

Começando pelo CleanArch.Domain, é aqui que defino as entidades, regras de negócio e interfaces de serviços do meu software. Foco nas preocupações centrais do meu negócio, mantendo essa camada independente de qualquer framework ou tecnologia específica.

No CleanArch.Application, lido com a lógica de aplicação e os casos de uso do software. Essa parte depende do CleanArch.Domain para implementar os serviços e regras de negócio que defini anteriormente. Utilizo padrões de projeto como Repositório e DTOs (Data Transfer Objects) para manter a estrutura organizada.

Para a camada de infraestrutura de dados, desenvolvi o CleanArch.Infra.Data. É nesse projeto que realizo operações de acesso a dados, como persistência e recuperação de informações em bancos de dados, APIs ou outros mecanismos de armazenamento. Essa camada depende tanto do CleanArch.Domain quanto do CleanArch.Application para obter as definições e interfaces necessárias.

Pensando na configuração e injeção de dependências, criei o CleanArch.Infra.Ioc. Aqui, defino e configuro os contêineres de inversão de controle (IoC), que permitem a conexão flexível e desacoplada entre as diferentes partes do meu sistema. Essa camada é fundamental para garantir a modularidade e extensibilidade do software.

O CleanArch.WebUi é o projeto responsável pela interface do usuário (UI) do meu software. Aqui implemento as camadas de apresentação, incluindo a lógica para receber e enviar dados ao usuário. Essa camada depende do CleanArch.Application para executar as operações de negócio e proporcionar uma experiência interativa aos usuários.

Por fim, temos o CleanArch.xUnit, o projeto dedicado aos testes automatizados. Aqui escrevo casos de teste para verificar a correta implementação das funcionalidades do meu software. Esses testes garantem a integridade e qualidade do código que desenvolvi.

No geral, meu projeto em Clean Architecture segue os princípios dessa abordagem para criar uma estrutura modular, flexível e de fácil manutenção. Cada projeto desempenha um papel definido e depende dos outros para criar um sistema coeso e bem organizado. Essa abordagem me permite ter uma separação clara das preocupações e um código escalável e testável.