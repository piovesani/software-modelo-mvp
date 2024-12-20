# Controle de Funcionários

Este é um software desenvolvido em C# e WPF para controle de funcionários, utilizando o padrão MVP (Model-View-Presenter) e o Entity Framework com banco de dados In-Memory.

## Funcionalidades

- Cadastro de funcionários com informações como nome, cargo, e data de admissão.
- Listagem e consulta de funcionários registrados.
- Edição e exclusão de registros existentes.
- Persistência de dados em memória durante a execução da aplicação.

## Requisitos

- **.NET 6 ou superior**
- **Visual Studio 2022 ou superior**

## Tecnologias Utilizadas

- **C#**: Linguagem principal do desenvolvimento.
- **WPF (Windows Presentation Foundation)**: Interface gráfica.
- **Entity Framework Core**: ORM para acesso a dados.
- **Banco de Dados In-Memory**: Para persistência temporária.

## Como Executar o Projeto

1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
   ```

2. Abra o projeto no Visual Studio.

3. Restaure as dependências do projeto:
   ```bash
   dotnet restore
   ```

4. Compile e execute o projeto:
   - No Visual Studio, pressione `F5`.

5. A aplicação será iniciada, permitindo o cadastro e a gestão de funcionários.

## Estrutura do Projeto

- **Model**: Contém as classes que representam as entidades e regras de negócio.
- **View**: Responsável pela interface do usuário, utilizando XAML.
- **Presenter**: Implementa a lógica de apresentação, fazendo a ponte entre o Model e a View.

## Contribuindo

Sinta-se à vontade para contribuir com este projeto. Para isso:

1. Faça um fork deste repositório.
2. Crie uma nova branch para suas alterações:
   ```bash
   git checkout -b minha-feature
   ```
3. Faça as alterações necessárias e envie um pull request.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
