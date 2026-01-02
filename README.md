# Nexus ECommerce  
## Curso Desenvolvedor Backend – From Zero to Arquitetura Profissional

Este repositório contém o **projeto oficial do Curso Desenvolvedor Backend**, ministrado por **Prof. Eng. Cristiano de Paula**, e representa muito mais do que um conjunto de códigos:  
ele materializa **decisões de engenharia**, **padrões arquiteturais** e **práticas profissionais adotadas em sistemas reais de alta escala**.

> Este não é um curso de CRUD.  
> Aqui não ensinamos apenas a escrever código.  
> Ensinamos **como pensar como um desenvolvedor backend sênior**.

---

## 🎯 Propósito do Curso

O curso tem como objetivo formar **desenvolvedores backend capazes de sustentar sistemas em produção**, com foco em:

- Arquitetura e tomada de decisão técnica  
- Performance, custo e escalabilidade  
- Cloud-native backend  
- Código previsível, mensurável e sustentável  

Aqui, **código é apenas o começo**.

---

## 👨‍💻 Perfil do Profissional Formado

Ao final do curso, o aluno terá desenvolvido competências para atuar como:

- Desenvolvedor Backend Sênior  
- Tech Lead Backend  
- Arquiteto de APIs e serviços  
- Profissional capaz de justificar decisões técnicas com métricas  

> O sênior é pago pelo que decide **não fazer**, tanto quanto pelo que faz.

---

## 🧱 O Projeto Nexus ECommerce

O **Nexus ECommerce** é o projeto central do curso.  
Ele simula a construção de uma **plataforma de e-ECommerce projetada para alta carga**, preparada para:

- Picos extremos de acesso (ex.: Black Friday)
- Alta concorrência
- Integrações externas
- Evolução contínua da arquitetura

> O objetivo não é aprender a fazer CRUD.  
> O objetivo é aprender a **construir um sistema que aguenta a Black Friday**.

---

## 🏗️ Visão Arquitetural


├── NexusECommerce.Api → Camada de Apresentação (Web APIs)
├── NexusECommerce.Application → Regras de Negócio
├── NexusECommerce.Domain → Domínio, Entidades e Contratos
├── NexusECommerce.Infrastructure → Persistência e Integrações

O projeto é desenvolvido utilizando uma **arquitetura em camadas**, evoluindo gradualmente para cenários mais avançados.


### Princípios Arquiteturais
- Separação clara de responsabilidades  
- Baixo acoplamento  
- Decisões orientadas a custo e performance  
- Arquitetura evolutiva (não engessada)  

---

## 🚀 Como o Projeto é Construído

O Nexus Commerce **nasce do zero** e evolui ao longo dos módulos do curso.

### 🔹 Módulo 1 – Ambiente e Fundamentos
- Preparação profissional do ambiente
- Cloud, versionamento e ferramentas
- Primeira API funcional
- Exposição segura de serviços locais
- Debug e testes reais de API

### 🔹 Módulo 2 – C# Avançado e Performance
- Funcionamento interno do .NET
- IL, JIT e AOT
- Stack vs Heap
- Garbage Collector
- Benchmarking com BenchmarkDotNet
- Decisões baseadas em métricas

> Sem medição, performance vira opinião.

### 🔹 Módulos Avançados
Ao longo do curso, o projeto incorpora:

- Cache distribuído (Redis)
- Mensageria (RabbitMQ)
- Persistência híbrida (SQL + NoSQL)
- Microsserviços
- API Gateway
- Docker e containerização
- CI/CD
- Segurança e arquitetura limpa
- Edge Computing e Cloud

---

## 🧪 Métrica, Performance e Engenharia

O curso ensina que:

- Código correto não garante eficiência
- Toda alocação de memória tem custo
- GC resolve problemas, mas cobra em latência
- Decisão técnica sem métrica é opinião

Ferramentas e práticas utilizadas:
- BenchmarkDotNet
- Análise de alocação
- Leitura de impacto em GC
- Avaliação de trade-offs reais

---

## 🔐 Cloud e Exposição de Serviços

Backend moderno **nasce na nuvem**.

Durante o curso:
- APIs locais são expostas com **Cloudflare Tunnels**
- Sem abertura manual de portas
- Comunicação criptografada
- Simulação real de integrações externas

---

## 🛠 Tecnologias Utilizadas

- .NET 10
- ASP.NET Core
- Visual Studio Community 2026
- Git e GitHub
- Docker
- SQL Server
- Redis
- RabbitMQ
- Cloudflare
- Azure
- BenchmarkDotNet
- Postman / Bruno

---

## 📌 Filosofia do Curso

- Backend sem métrica é chute  
- Código simples pode ser caro  
- Produção não perdoa desperdício  
- Arquitetura é escolha, não moda  

> Backend profissional não escolhe o que funciona.  
> Escolhe o que **escala**.

---

## 🧭 Resultado Esperado

Ao final do curso, este repositório representará:

- Um projeto backend completo
- Decisões arquiteturais justificadas
- Código orientado a escala
- Uma base sólida para ambientes reais de produção

---

## 📎 Observação Final

Este repositório é **educacional**, mas segue **padrões reais de mercado**.  
Tudo o que é construído aqui foi pensado para **existir em produção**.

> Se só funciona localmente, não está pronto.  
> Se não escala, não é profissional.

