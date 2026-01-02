Nexus Ecommerce
Curso Desenvolvedor Backend – .NET 10

O Nexus Ecommerce é o projeto oficial desenvolvido ao longo do Curso Desenvolvedor Backend, com o objetivo de ensinar, de forma prática e estruturada, a construção de APIs modernas, seguras e escaláveis utilizando .NET 10 e ASP.NET Core.

Este repositório representa um projeto realista, evoluído passo a passo, desde a criação da solution vazia até a implementação de uma arquitetura profissional, seguindo padrões amplamente adotados pelo mercado.

🎯 Objetivo do Projeto

Ensinar backend de forma progressiva e profissional

Consolidar boas práticas de arquitetura e organização

Aplicar padronização de código e versionamento

Trabalhar com testes de API e exposição segura de serviços

Criar uma base sólida para evolução contínua

O foco não é apenas “fazer funcionar”, mas construir algo que valha a pena manter.

🧱 Visão Geral da Arquitetura

O projeto adota uma arquitetura em camadas, organizada por responsabilidade:

NexusEcommerce
│
├── NexusEcommerce.Api           → Camada de Apresentação (Web API)
├── NexusEcommerce.Application   → Regras de Negócio
├── NexusEcommerce.Domain        → Entidades e Contratos
└── NexusEcommerce.Infrastructure→ Dados e Integrações

Princípios adotados

Separação clara de responsabilidades

Baixo acoplamento entre camadas

Código previsível e legível

Facilidade de manutenção e evolução

🚀 Como o Projeto Será Desenvolvido

O Nexus Ecommerce não nasce pronto. Ele é construído do zero, acompanhando a evolução do curso.

Etapas principais
1️⃣ Preparação do Ambiente

Instalação do .NET 10

Configuração do Visual Studio

Git, Postman, Bruno e Cloudflare Tunnel

Padronização inicial com .editorconfig

2️⃣ Criação da Solution

Solution vazia como ponto de partida

Criação dos projetos por camada

Definição das dependências corretas

3️⃣ Primeiro MVP

Criação do primeiro endpoint (Health)

Validação do pipeline da API

Debug profissional

Testes manuais com Postman/Bruno

Exposição segura via Cloudflare Tunnel

4️⃣ Evolução Funcional

Introdução de entidades de domínio

Regras de negócio na camada Application

Persistência e integrações na Infrastructure

Endpoints reais de negócio

5️⃣ Consolidação Arquitetural

Padronização de contratos

Organização de DTOs

Tratamento de exceções

Preparação para ambientes (Development / Production)

Cada etapa é pensada para simular decisões reais de projetos profissionais.

🧪 Testes e Validação

O curso trabalha com testes de API desde o início, utilizando:

Postman para testes manuais e exploração

Bruno para testes versionados como código

Validação de contratos simples e previsíveis

A ideia é mostrar que backend sem testes vira gargalo do time.

🔐 Exposição Segura de APIs

Durante o curso, as APIs locais são expostas de forma segura utilizando:

Cloudflare Tunnels

Comunicação criptografada

Sem abertura manual de portas

Ideal para testes externos, webhooks e integrações

Isso aproxima o aluno de cenários reais de desenvolvimento.

🛠 Tecnologias Utilizadas

.NET 10

ASP.NET Core Web API

Visual Studio Community 2026

Git e GitHub

Postman

Bruno

Cloudflare Tunnels

👥 Público-Alvo

Este curso e este repositório são destinados a:

Estudantes de desenvolvimento backend

Desenvolvedores iniciantes em .NET

Profissionais em transição de carreira

Desenvolvedores que desejam organização, arquitetura e padrão, não apenas código funcional

📌 Importante

Este projeto é educacional, mas segue práticas reais de mercado.
O foco é qualidade, clareza e evolução contínua.

Código é lido mais vezes do que escrito.
Se só funciona localmente, não está pronto.
