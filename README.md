# Sistema de Fluxo de Caixa para ONGs 📊

### 💡Sobre o Projeto
Este é um **Sistema Web de Fluxo de Caixa** desenvolvido para auxiliar na **gestão financeira de organizações sem fins lucrativos (ONGs)**. Criado como um projeto de extensão, ele oferece ferramentas simples e eficientes para controlar receitas e despesas, proporcionando maior transparência e organização financeira para atividades sociais.
Com uma interface intuitiva, o sistema permite que ONGs gerenciem suas movimentações financeiras de forma clara, facilitando o acompanhamento da saúde financeira da organização.

---
### 🚀 **Funcionalidades Principais**
- Registro e categorização de receitas e despesas.
- Registro de movimentações financeiras de entrada e de saida.
- Registro  de fornecedores e de colaboradpres.
- Interface simples e responsiva para acesso em dispositivos móveis e desktops.
- Controle de usuários e permissões para maior segurança.
  
---

## 🛠 **Tecnologias Utilizadas**
O projeto foi construído utilizando as seguintes tecnologias e frameworks:

- **ASP.NET Core**: Framework para desenvolvimento de aplicações web modernas e de alto desempenho.
- **C#**: Linguagem de programação utilizada para implementar a lógica de negócios.
- **Bootstrap**: Framework CSS para criação de uma interface responsiva e estilizada.
- **Razor:** Engine de visualização utilizada para construir as interfaces de usuário dinâmicas (HTML).
- **Entity Framework Core**: ORM para mapeamento de objetos ao banco de dados e simplificação de consultas.
- **MariaDB**: Banco de dados relacional usado para armazenamento e gerenciamento de dados.

---

## 📐 Arquitetura e Padrões de Design

Este projeto foi desenvolvido seguindo princípios de **Clean Architecture**, visando uma estrutura robusta, modular e de fácil manutenção. As principais decisões de design incluem:

* **Padrão MVC (Model-View-Controller):** Utilizado na camada web para separar claramente as responsabilidades de interface de usuário (Views), lógica de negócios (Models) e controle de fluxo (Controllers).
* **Views com Razor:** A renderização das interfaces de usuário (HTML) foi implementada utilizando a engine de views **Razor**, que facilita a criação dinâmica de páginas web em ASP.NET Core.
* **Separação de Preocupações (SoC):** A aplicação adere à separação de camadas (Domínio, Aplicação, Infraestrutura, Apresentação) para garantir que cada parte do sistema tenha uma responsabilidade única e bem definida, tornando-o mais testável e escalável.

--
### 📚 **Objetivo Educacional**
Este projeto foi desenvolvido como parte de uma matéria de extensão, com o principal objetivo de aplicar e consolidar conhecimentos práticos em:

* **Desenvolvimento Web com Padrão MVC:** Entendimento e aplicação do padrão Model-View-Controller.
* **Integração de Aplicações com Banco de Dados Relacional:** Conexão e manipulação de dados em bancos relacionais.
* **Criação de Interfaces Amigáveis e Acessíveis:** Foco na experiência do usuário e usabilidade.
  
---
### 🌟 **Funcionalidades Futuras**
Estou trabalhando para adicionar as seguintes melhorias ao sistema:

- Permissionamento de Usuários: Implementação de níveis de acesso e controle de permissões, permitindo que administradores gerenciem o que cada usuário pode visualizar ou modificar no sistema.
- Relatórios Avançados: Geração de relatórios personalizados com gráficos interativos, exportação em PDF/Excel e filtros detalhados para análises financeiras.
  
---
## ⚙️ Como Configurar e Rodar o Projeto

Para ter o sistema rodando em sua máquina local, siga os passos abaixo:

1.  **Clone o Repositório:**
2.  **Configurar o Banco de Dados:**
    * Certifique-se de ter o MariaDB instalado e rodando.
    * Crie um banco de dados vazio (ex: `fluxodb`).
    * Atualize a string de conexão no arquivo `appsettings.json` (ou `appsettings.Development.json`) com as credenciais do seu banco de dados:
        ```json
        "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Port=3306;Database=fluxo_caixa_db;Uid=seu_usuario;Pwd=sua_senha;"
        }
        ```
    * Execute as migrações do Entity Framework Core para criar as tabelas:
        ```bash
        dotnet ef database update
        ```
3.  **Restaurar Dependências e Rodar:**
    ```bash
    dotnet restore
    dotnet run
    ```
    O sistema estará disponível em `https://localhost:5001` (ou a porta indicada no console).
---
## 📄 Licença
Este projeto está sob a licença [MIT License](https://opensource.org/licenses/MIT).
---
**Desenvolvido com ❤️ por SamaraFerC
<!--
## Organização do projeto no Trello: https://trello.com/b/NZux9SYy/constru%C3%A7%C3%A3o-de-software
## Protótipo no Figma: https://www.figma.com/design/tsUqMnHbvq9XitDxZMM9Fc/prot%C3%B3tipo?node-id=0-1&node-type=CANVAS&t=DAIR1b724U8iusyA-0
## Documentação de requisitos com os diagramas: https://docs.google.com/document/d/1xQBWLZikWpR6-mUG0FF5efUyXj4a5mKs_bAitUdAJiE/edit -->
