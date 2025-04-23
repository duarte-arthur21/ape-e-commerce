# Teste Técnico da Rota das Oficinas
Este projeto é o modelo a ser utilizado para criar uma API Web básica para e-commerce.
Ele já contém a estrutura básica de uma API, que deve ser seguida ao adicionar mais funcionalidades.

Algumas características deste modelo são:

- Construído usando .NET 8.0
- Utiliza o EntityFramework Core como ORM
- Segue o [Padrão CQRS](https://learn.microsoft.com/en-us/azure/architecture/patterns/cqrs) e o [Padrão Repositório](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-design)
- Utiliza PostgreSQL como mecanismo de banco de dados
- Utiliza Xunit, Bogus e FluentAssertions para criar testes

## Tarefas no Projeto
No modelo, existem alguns recursos inacabados que você precisa executar para criar a API corretamente. Pesquise **[TODO]** para encontrar esses recursos.

## Sinta-se à vontade para otimizar ou refatorar
Se encontrar algum código que considere necessário, sinta-se à vontade para refatorá-lo. Mas a refatoração deve seguir os padrões do projeto. Além disso, a refatoração deve ser separada em seu próprio commit.

## Criando um Front-End
Ao criar o front-end, você pode escolher qualquer framework que desejar, mas sua aplicação deve se conectar à API Web por meio de requisições HTTP e seu código deve estar no mesmo repositório que a API Web.