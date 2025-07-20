# CheckList de Inspeções em Salas Elétricas #

## Descrição do Projeto ##

<p>Essa aplicação foi desenvolvida em C# utilizando Windows Forms. O objetivo do sistema é permitir registros das inspeções realizadas pelos técnicos em salas elétricas, incluindo a data da inspeção, nome do técnico, o CCM inspecionado e um espaço para comentários. Todos estes dados são salvos em um banco de dados SQLite, permitindo a consulta em momentos futuros. </p>

<hr>

## Funcionalidades ##
* **Registro das inspeções**: permite o registro detalhado das atividades com campos para data, nome do técnico, seleção do CCM, itens pré-definidos no checklist e espaço para comentários.
* **Gereciamento dos CCMs**: mantém uma lista dos Centros de Controle de Motores que podem ser selecionados durante o registro.
* **Checklist Pré-definido**: facilita a padronização das atividades.
* **Armazenamento de dados** e visualização de histórico: utiliza SQLite para armazenar as informações e permite a visualização das inspeções realizadas anteriormente.

<hr>

## Tecnologias Utilizadas ##
* C#
* Windows Forms
* Visual Studio 2022
* SQLite

<hr>

## Como Usar ##
### Pré-requisitos ###
<p>Para executar este projeto, você precisará ter o .NET Framework (ou .NET SDK compatível) instalado em sua máquina. Recomenda-se o Visual Studio para abrir e compilar o projeto.</p>

### Instalação e Execução ###

1. Clone o repositório.
2. Navegue até o diretório do projeto.
3. Abra o arquivo CheckListInspecao.sln com o Visual Studio.
4. No Visual Studio, compile o projeto (Build > Build Solution) e execute-o (Debug > Start Debugging ou pressione F5).

<hr>

## Estrutura do Projeto ##
* `Banco.cs`: arquivo que contém a definição do banco de dados e a lógica para conexão do app com o SQLite.
* `Form1.cs`: arquivo que contém a lógica da interface com o usuário.
* `Inspecao.cs`: arquivo com as definições da classe Inspeção.

<hr>

## Implementações Futuras ##
<p>Este projeto ainda está em desenvolvimento!</p>
<p>Licença MIT.</p>

