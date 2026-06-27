![logo](./.github/assets/logo_guia_inicial.png)

![.NET versão](https://img.shields.io/badge/.NET-10.0-blue) ![Licença MIT](https://img.shields.io/badge/license-MIT-green)

Este repositório **Guia Inicial de C#** serve como ponto de partida para iniciantes conhecerem a linguagem C# e seu ecossistema. Nele apresentamos uma visão geral da linguagem (origem, propósito e estatísticas de uso), além de instruções de instalação do SDK do .NET em Windows, macOS e Linux. O foco é ensinar conceitos básicos e boas práticas de Git/GitHub colaborativo, por meio de exemplos de código simples organizados nas pastas do repositório. 

## Objetivo do Repositório

O objetivo deste repositório é criar um **guia inicial em Markdown** para a linguagem C#, focado em alunos iniciantes. O conteúdo inclui uma introdução à linguagem, explicação das principais áreas de aplicação, prós e contras da linguagem, pré-requisitos de ambiente e instruções passo a passo para instalar o .NET SDK em diferentes sistemas operacionais. Além disso, o repositório apresenta exemplos de código simples em C# (na pasta `exemplos/`) e orientações sobre fluxo de trabalho colaborativo usando Git/GitHub.

## Introdução e História da Linguagem

C# é uma **linguagem de programação multiparadigma de tipagem forte** criada pela Microsoft como parte da plataforma .NET. Inicialmente desenvolvida por Anders Hejlsberg e sua equipe em 1999 sob o codinome “Cool”, foi apresentada publicamente em 2000 (durante a conferência PDC) já sob o nome C#. A linguagem foi influenciada por C e C++, integrando conceitos de orientação a objetos e outros recursos modernos. Ao longo dos anos, C# evoluiu junto com o .NET, sendo amplamente utilizada em aplicações corporativas, jogos (Unity), web (ASP.NET Core) e muito mais. Segundo a própria Microsoft, C# é hoje **uma das cinco linguagens mais populares no GitHub**, empregada em setores como mídia, finanças, saúde e jogos.

## Principais Áreas de Aplicação

C# é uma linguagem versátil e **multiplataforma** (rodando no Windows, Linux e macOS via .NET). As principais áreas de aplicação incluem:

- **Desenvolvimento Web:** com ASP.NET Core e Blazor para sites e APIs web de alto desempenho.
- **Aplicativos Desktop:** tanto clássicos no Windows (WPF, WinForms) quanto multiplataforma usando .NET MAUI.
- **Aplicativos Mobile:** apps para Android e iOS via .NET MAUI (sucessor do Xamarin).
- **Jogos e Entretenimento:** C# é muito usado em frameworks de jogos como Unity e MonoGame.
- **Nuvem e Microserviços:** serviços escaláveis no Azure ou AWS usando o runtime .NET.
- **IoT e Ciência de Dados:** prototipagem em Raspberry Pi e processamento de dados (ML.NET).
  
Segundo a Microsoft, “com o .NET você pode criar qualquer tipo de aplicativo em qualquer plataforma”, do mobile ao servidor na nuvem. Essa abrangência faz de C# uma opção comum tanto para startups quanto para grandes empresas.

## Vantagens e Desvantagens

**Vantagens:** C# combina facilidade de uso com recursos avançados. É *fortemente tipada* (reduz erros de tipo em tempo de compilação) e suporta completo OOP (classes, interfaces, herança). Oferece genéricos, *LINQ* para consultas integradas a coleções, *async/await* para programação assíncrona, *pattern matching*, *records* (para estruturas de dados imutáveis) e muito mais. O ambiente .NET fornece uma grande biblioteca padrão e ferramentas de depuração/padrões de projeto robustos. Além disso, por ser *open source* e multiplataforma, C# hoje roda em diversas arquiteturas. A comunidade é ativa e há extensa documentação oficial (MS Learn) e exemplos públicos.

**Desvantagens:** Historicamente, C# era muito atrelada ao Windows e à stack Microsoft, o que limitava sua adoção inicial em outras plataformas. Embora o .NET Core e .NET 10+ sejam multiplataforma, ainda é comum que C# seja associado a tecnologias Windows (por exemplo, WPF só roda no Windows). Outras possíveis limitações incluem a menor flexibilidade em scripts comparado a linguagens dinamicamente tipadas. Por fim, desenvolver aplicações para domínio específico fora do ecossistema .NET (por exemplo, desenvolvimento nativo para iOS em Swift) pode ser menos natural com C#. 

## Pré-requisitos

Antes de usar este guia, é necessário ter algumas ferramentas instaladas:

- **.NET SDK:** Versão atual de longo prazo (LTS). Assumimos .NET 10.0 (LTS) como alvo padrão, já que é a versão mais recente de manutenção. O SDK inclui compilador C# e runtime necessários para executar os exemplos.
- **Editor/IDE:** Um editor de código ou IDE configurado para C#. Recomendamos *Visual Studio 2026* (Windows), *Visual Studio Code* (Windows/macOS/Linux) ou *JetBrains Rider* (multiplataforma). Veja a seção “Comparativo de IDEs/Editores” abaixo para detalhes e links oficiais.
- **Sistema Operacional:** Instruções de instalação abaixo cobrem Windows 10/11, macOS (12+), e distribuições populares de Linux (Ubuntu, Fedora, etc).

## Instruções de Instalação do .NET SDK

As instruções abaixo mostram como instalar o **.NET SDK** (que inclui o compilador C# e o runtime) em cada sistema:

- **Windows:** Baixe o instalador do site oficial (página de *Downloads do .NET*) para Windows (x64 ou x86, conforme sua máquina). Como alternativa, use o Windows Package Manager (WinGet) abrindo o PowerShell como administrador e executando:  
  ```
  winget install Microsoft.DotNet.SDK.10
  ```  
  Esse comando instala a versão 10 do SDK (LTS). Verifique a instalação com `dotnet --version`.
  
- **macOS:** Acesse o site de download do .NET e selecione a versão desejada (geralmente a última LTS). Faça o download do pacote `.dmg` adequado (Apple Silicon ou Intel) e execute o instalador. Alternativamente, se você usa Homebrew, execute:  
  ```
  brew install --cask dotnet-sdk
  ```  
  Este comando instala a versão mais recente do SDK via Homebrew.

- **Linux (Ubuntu/Debian):** Configure os repositórios do .NET conforme a documentação oficial da Microsoft. Em distros Ubuntu recentes, é possível usar:  
  ```
  sudo apt-get update && sudo apt-get install -y dotnet-sdk-10.0
  ```  
  Esse comando instala o .NET 10 SDK a partir dos repositórios padrão (por exemplo, Ubuntu 26.04). Em outras distribuições, consulte as instruções específicas no site da Microsoft (por exemplo, Fedora, openSUSE, etc.). Se preferir, há também um **script oficial** de instalação que automatiza o processo.

## Estrutura do Repositório

## Fontes Consultadas

- Documentação oficial do C# e .NET (Microsoft Learn).  
- Página de downloads do .NET (site da Microsoft).  
- Guia C# no Microsoft Learn (pt-BR).  
- Página “O que você pode criar com C#” (Microsoft).  
- Site do Visual Studio Code (documentação e download).  
- Licença MIT no OpenSource.org.  

Estas referências serviram para embasar definições, sintaxe e orientações de instalação. As instruções aqui compiladas são de livre adaptação do material oficial, visando clareza para iniciantes em C#.

