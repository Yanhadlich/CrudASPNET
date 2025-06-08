<h1>🧪 CRUD ASP.NET Core + Docker + MySQL</h1>

<p>Este é um projeto simples de <strong>CRUD em ASP.NET Core</strong>, criado com o objetivo de <strong>praticar a linguagem C# e a criação de APIs REST</strong>.</p>

<p>O projeto simula uma API para cadastro de <strong>Clientes</strong> e <strong>Escritórios</strong>, com persistência em um banco de dados <strong>MySQL</strong>, utilizando <strong>Docker</strong> para facilitar o ambiente de desenvolvimento.</p>

<hr>

<h2>🚀 Tecnologias Utilizadas</h2>
<ul>
  <li>ASP.NET Core</li>
  <li>Entity Framework Core</li>
  <li>MySQL</li>
  <li>Docker e Docker Compose</li>
  <li>Swagger</li>
</ul>

<hr>

<h2>📦 Como rodar o projeto com Docker</h2>

<h3>Pré-requisitos:</h3>
<ul>
  <li>Docker instalado</li>
  <li>Docker Compose instalado</li>
</ul>

<h3>Passos:</h3>
<ol>
  <li>Clone o repositório:
    <pre><code>git clone https://github.com/seu-usuario/seu-repositorio.git
cd seu-repositorio</code></pre>
  </li>
  <li>Suba os containers:
    <pre><code>docker-compose up --build</code></pre>
  </li>
  <li>Acesse o Swagger para testar a API:
    <pre><code>http://localhost:5000/swagger</code></pre>
  </li>
</ol>

<hr>

<h2>📂 Estrutura do Projeto</h2>

<pre>
├── Person.API/             → Projeto principal ASP.NET Core
│   ├── Controllers/        → Endpoints da API
│   ├── Models/             → Entidades Cliente e Escritório
│   ├── Data/               → DbContext e Migrations
│   └── Program.cs
├── docker-compose.yml      → Orquestração dos containers
├── Dockerfile              → Build da imagem da API
└── README.md
</pre>

<hr>

<h2>🧪 Endpoints principais</h2>

<ul>
  <li><code>GET /api/clientes</code> – Listar todos os clientes</li>
  <li><code>POST /api/clientes</code> – Cadastrar novo cliente</li>
  <li><code>PUT /api/clientes/{id}</code> – Atualizar cliente</li>
  <li><code>DELETE /api/clientes/{id}</code> – Remover cliente</li>
  <li><code>GET /api/escritorios</code> – Listar escritórios</li>
</ul>

<p>Todos os endpoints podem ser testados via <strong>Swagger</strong>.</p>

<hr>

<h2>🧼 Parar e limpar os containers</h2>
<pre><code>docker-compose down</code></pre>

<hr>

<h2>📘 Referências</h2>
<ul>
  <li><a href="https://learn.microsoft.com/aspnet/core">Documentação ASP.NET Core</a></li>
  <li><a href="https://learn.microsoft.com/ef/core/">Entity Framework Core</a></li>
  <li><a href="https://hub.docker.com/_/mysql">Imagem oficial do MySQL no Docker Hub</a></li>
  <li><a href="https://learn.microsoft.com/dotnet/core/docker/">Docker para .NET</a></li>
</ul>

<hr>

<h2>📖 Licença</h2>
<p>Este projeto está sob a licença MIT. Sinta-se livre para usar e modificar.</p>
