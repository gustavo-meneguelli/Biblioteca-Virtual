# Biblioteca Virtual

Este é um projeto de console para gerenciar uma biblioteca virtual. O projeto inclui funcionalidades básicas para exibir menus, listar livros, e gerenciar informações de usuários.

## Funcionalidades

- **MenuService**: Gerencia a exibição dos menus e as interações com o usuário.
- **Book**: Representa os detalhes dos livros (título, autor, preço).
- **Inventory**: Contém uma coleção de livros populares e fornece métodos para acessar a lista de livros.
- **User**: Representa as informações dos usuários.

## Estrutura do Projeto

- `BibliotecaVirtual.Models`
  - **Book**: Define a estrutura dos livros.
  - **Inventory**: Gerencia a lista de livros disponíveis.
  - **User**: Armazena informações dos usuários.
  - **Payment**: Classe abstrata para servir de modelo para as formas de pagamento.
  - **CreditCardPayment**: Realiza a forma de pagamento por cartão de crédito.

- `BibliotecaVirtual.Services`
  - **MenuService**: Responsável pela exibição de menus e interações com o usuário.
- **PaymentService**: Responsável pela lógica de pagamento (incompleto)

## Como Executar

Para executar o projeto, abra o arquivo `BibliotecaVirtual.sln` no Visual Studio e execute o projeto. 

## Atualizações Recentes 09/08

### Refatoração de Código
- Refatoração dos métodos em `MenuService`.
- Padronização dos nomes dos métodos para inglês.
- Melhorias na validação de entrada do usuário.
- Integração do `PaymentService` para gerenciar pagamentos.

Essas mudanças melhoram a clareza e a manutenibilidade do código, além de preparar o sistema para futuras expansões de funcionalidades.


## Contribuições

Sinta-se à vontade para contribuir com melhorias ou relatar problemas. 

---

**Desenvolvedor**: Gustavo Meneguelli Soares
