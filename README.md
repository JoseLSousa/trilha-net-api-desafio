# API gerenciador de tarefas em ASP.NET

Este projeto implementa uma API para gerenciamento de tarefas, permitindo criar, atualizar, e obter tarefas por vários critérios. A API é construída utilizando ASP.NET e C#

## Endpoints

### Obter Tarefa por ID

**GET /Tarefa/{id}**

Retorna a tarefa com o ID especificado.

**Parâmetros:**
- `id` (int): ID da tarefa.

**Respostas:**
- `200 OK`: Retorna a tarefa.
- `404 Not Found`: Se a tarefa não for encontrada.

### Obter Todas as Tarefas

**GET /Tarefa/ObterTodos**

Retorna todas as tarefas no banco de dados.

**Respostas:**
- `200 OK`: Retorna a lista de todas as tarefas.

### Obter Tarefas por Título

**GET /Tarefa/ObterPorTitulo**

Retorna tarefas que contêm o título especificado.

**Parâmetros:**
- `titulo` (string): Título ou parte do título da tarefa.

**Respostas:**
- `200 OK`: Retorna as tarefas correspondentes.
- `404 Not Found`: Se nenhuma tarefa for encontrada com o título especificado.

### Obter Tarefas por Data

**GET /Tarefa/ObterPorData**

Retorna tarefas que possuem a data especificada.

**Parâmetros:**
- `data` (DateTime): Data da tarefa.

**Respostas:**
- `200 OK`: Retorna as tarefas correspondentes.

### Obter Tarefas por Status

**GET /Tarefa/ObterPorStatus**

Retorna tarefas que possuem o status especificado.

**Parâmetros:**
- `status` (EnumStatusTarefa): Status da tarefa.

**Respostas:**
- `200 OK`: Retorna as tarefas correspondentes.

### Criar Nova Tarefa

**POST /Tarefa**

Cria uma nova tarefa.

**Corpo da Requisição:**
- `Tarefa`: Objeto Tarefa contendo as informações da nova tarefa.

**Respostas:**
- `201 Created`: Retorna a tarefa criada.
- `400 Bad Request`: Se a data da tarefa for inválida.

### Atualizar Tarefa

**PUT /Tarefa/AtualizarTarefa/{id}**

Atualiza uma tarefa existente com o ID especificado.

**Parâmetros:**
- `id` (int): ID da tarefa a ser atualizada.

**Corpo da Requisição:**
- `Tarefa`: Objeto Tarefa contendo as novas informações da tarefa.

**Respostas:**
- `200 OK`: Retorna a tarefa atualizada.
- `404 Not Found`: Se a tarefa não for encontrada.
- `400 Bad Request`: Se a data da tarefa for inválida.

## Estrutura do Projeto

- **Controllers**: Contém o `TarefaController` que define todos os endpoints da API.
- **Models**: Define os modelos de dados, como a classe `Tarefa`.
- **Data**: Contém o contexto do banco de dados `OrganizadorContext`.

## Requisitos

- .NET 6 ou superior
- Entity Framework Core

## Configuração

1. Clone o repositório.
2. Configure a string de conexão no arquivo `appsettings.json`.
3. Execute as migrações do Entity Framework para criar o banco de dados.

   ```bash
   dotnet ef database update
   ```
