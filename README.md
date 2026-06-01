# 

# \# BrainX — O Santuário Cognitivo 🧠🚀

# 

# O \*\*BrainX\*\* é uma plataforma Full Stack de estudos gamificada, projetada para centralizar materiais de aprendizagem, gerir rotinas de foco profundo e fornecer um tutor virtual inteligente capaz de operar totalmente em ambientes locais (offline). 

# 

# A aplicação propõe um ecossistema minimalista — o "Santuário Cognitivo" — que mitiga as distrações do ambiente digital moderno e estimula a consistência do estudante através de mecânicas de recompensa por engajamento.

# 

# \---

# 

# \## 👥 Integrantes do Grupo

# \* \*\*Thalles Eduardo\*\*

# \* \*\*Gladistone Araújo\*\*

# \* \*\*Rafael Felipe\*\*

# \* \*\*Gabriel Generoso\*\*

# 

# \---

# 

# \## 🛠️ Stack Tecnológica

# 

# \### Frontend

# \* \*\*React\*\* com \*\*TypeScript\*\* (Tipagem estática e segurança de código)

# \* \*\*Vite\*\* (Build e empacotamento de altíssima performance)

# \* \*\*Tailwind CSS\*\* (Estilização minimalista e responsiva por classes utilitárias)

# \* \*\*Framer Motion\*\* (Animações fluidas e transições imersivas)

# \* \*\*Lucide React\*\* (Biblioteca nativa de ícones vetoriais)

# 

# \### Backend \& Persistência

# \* \*\*C#\*\* sobre \*\*.NET Core / ASP.NET Core\*\* (Web API RESTful de alto desempenho)

# \* \*\*Entity Framework Core (EF Core)\*\* (Mapeamento Objeto-Relacional)

# \* \*\*SQLite\*\* (Banco de dados relacional embarcado, leve e altamente portátil)

# \* \*\*Swashbuckle (Swagger UI)\*\* (Interface visual para documentação e testes de endpoints)

# 

# \---

# 

# \## 💡 Recursos de Destaque \& Engenharia de Software

# 

# \### 1. Tutor IA Offline com Filtro de Acentos Resiliente

# O coração da plataforma é o atendimento do tutor virtual, alimentado nativamente via banco de dados (tabela `TutorKnowledge`) com mais de 60 tópicos avançados de C#, Matemática e Língua Portuguesa. 

# Para garantir buscas assertivas sem o uso de IA externa, foi implementado um algoritmo de normalização Unicode no C# (`NormalizationForm.FormD`). Ele remove acentuações gráficas e padroniza a caixa do texto, permitindo que entradas como \*"variável"\*, \*"VARIÁVEL"\* ou \*"variavel"\* encontrem a resposta correta instantaneamente.

# 

# \### 2. Conversão Base64 para Armazenamento Híbrido (O Cofre)

# Para dispensar servidores de arquivos complexos no MVP, o portfólio ("Meu Portfólio") aceita uploads de arquivos físicos de até \*\*5MB\*\*. O Frontend em React converte o arquivo em uma string de texto codificada em `Base64` através da API `FileReader` e a transmite para a API em C#, que a armazena diretamente em um campo de texto no SQLite de forma estável.

# 

# \### 3. Gamificação Nativa (XP, Níveis e Ofensiva)

# Para impulsionar a retenção e o hábito do estudante, foi desenvolvido um motor de gamificação que opera diretamente no navegador (`LocalStorage`), protegendo o banco contra concorrência:

# \* \*\*Fazer perguntas à IA:\*\* +10 XP

# \* \*\*Adicionar materiais ao Portfólio:\*\* +20 XP

# \* \*\*Concluir um ciclo Pomodoro:\*\* +50 XP

# O sistema calcula o limite de nível dinamicamente (Nível \* 100) e dispara um feedback visual flutuante de \*Level Up\*. O progresso e a "Ofensiva" (dias seguidos de estudo) são mantidos mesmo se o navegador for fechado.

# 

# \### 4. Engenharia de Foco: Pomodoro e Modo Zen

# \* \*\*Timer Pomodoro:\*\* Um cronômetro regressivo de 25 minutos integrado na barra superior da aplicação para gerenciar blocos de foco.

# \* \*\*Modo Zen:\*\* Um estado de imersão profunda acionado pelo usuário. Ao clicar, o React oculta sidebars, menus e contadores, alterando a paleta de cores para tons noturnos relaxantes (`#0f172a`), isolando o estudante apenas com o seu conteúdo de leitura ou chat.

# 

# \---

# 

# \## 📂 Organização das Rotas da API (Backend)

# 

# A API expõe endpoints em JSON documentados visualmente via Swagger em `http://localhost:5132/swagger`:

# 

# \* \*\*`POST /api/auth/register`\*\* e \*\*`POST /api/auth/login`\*\*: Gestão de identidade e devolução do identificador único (`UserId`).

# \* \*\*`POST /api/chat/ask`\*\*: Processamento de mensagens, criação automática de sessões por matéria e árvore de decisão para os chips dinâmicos de sugestão (\*follow-ups\*).

# \* \*\*`GET /api/chat/sessions/{userId}`\*\*: Carregamento do histórico relacional de conversas estruturado.

# \* \*\*`POST /api/portfolio/add`\*\* e \*\*`DELETE /api/portfolio/delete/{id}`\*\*: Controle, inserção e remoção física de itens do cofre acadêmico.

# 

# \---

# 

# \## ⚙️ Como Executar o Projeto Localmente

# 

# \### Configurando o Backend (C#)

# 1\. Certifique-se de possuir o \*\*.NET SDK 8.0+\*\* instalado.

# 2\. Na pasta raiz do backend, instale as dependências e o gerador do Swagger:

# Bash

# dotnet add package Swashbuckle.AspNetCore

# dotnet add package Microsoft.EntityFrameworkCore.Sqlite

# Execute as migrações para gerar o arquivo de banco local contendo a carga inicial de dados:

# Bash

# dotnet ef migrations add InicializarSantuario

# dotnet ef database update

# Inicie o servidor da API:

# 

# Bash

# dotnet run

# (A API estará rodando em http://localhost:5132).

# 

# Configurando o Frontend (React)

# Instale as dependências na pasta do frontend:

# 

# Bash

# npm install

# Inicie o servidor de desenvolvimento do Vite:

# 

# Bash

# npm run dev

# Abra o endereço gerado (geralmente http://localhost:5173 ou http://localhost:3000) no seu navegador.

