<h1>StudyPlanner</h1> 
C# | ASP.NET Core | Planejador Rápido de Estudos
<hr>
<h2>Intenção:</h2>
<span>
Este projeto está sendo desenvolvido com o objetivo primário de estudo
e treinamento nas ferramentas da plataforma <strong>.NET Core.</strong>
<br/><br/>
As ferramentas aqui utilizadas são aquelas que satisfazem às necessidades
de uma aplicação web, como: <strong>ASP.NET Core MVC, Entity Framework Core e C#</strong>,
como linguagem da plataforma .NET. 
<br/><br/>
Apesar do intuito didático, o StudyPlanner pretende oferecer uma funcionalidade
principal: utilizar algoritmos para organizar de forma automatizada uma rotina 
de estudos, retirando do estudando a carga cognitiva do planejamento.<br/><br/>
</span>
<div>
    No estado atual, a aplicação possui as seguintes funcionalidades:
</div>
<div>
    &nbsp; &nbsp; <strong>1.</strong> Criação de tarefas de estudo contendo Nome, Unidade/Capítulo atual, grau de prioridade de
    1 a 3 (passos de 0,5), Meta de horas de estudo e uma Descrição opcional.
    </div>
<div>
    &nbsp; &nbsp; <strong>2.</strong> Lista das tarefascriadas e suas características. Bem como botões
    com a opção de Iniciar uma Sessao de Estudo, Deletar e Editar a tarefa.<br/>
    Exemplo:<br/>
    <img src="https://github.com/gubelleza/StudyPlanner/blob/dev/AgendaEstudos/docs/imgs/CardTarefa.png" width="300">
    <br/>
</div>
<div>
    &nbsp; &nbsp; <strong>3.</strong> Sessões de estudo iniciadas e concluídas pelo usuário, que contabilizam
    as horas estudadas para uma determinada tarefa.
</div>
<div>
    &nbsp; &nbsp; <strong>4.</strong> Administrar a Rotina de Estudos, permitindo ao usuário atuar sobre 
    todas as tarefas existentes realizando as operações: Reiniciar, Deletar e Estabelecer
    uma meta para todas as tarefas registradas.
</div>
<div>
    &nbsp; &nbsp; <strong>5.</strong> A funcionalidade de Estabelecer uma Meta para todas as tarefas conta com um
    algoritmo que realiza a divisão proporcional da meta de horas geral inserida
    entre as diversas tarefas, considerando como peso o grau de prioridade de 
    cada tarefa.  
</div>

```C#
    // file: StudyPlanner/AgendaEstudos/Services/StatsService.cs
    
    public void AtribuirMetasProporcionais(double meta) {
        double unidadeComumHoras = meta / TotalFatorPrioridade;            
        foreach (Tarefa t in Tarefas) {
            t.MetaHoras = t.Prioridade * unidadeComumHoras;
            Console.WriteLine("Meta: " + t.MetaHoras);
        }
    }     
``` 

<div>
    &nbsp; &nbsp; <strong>6.</strong> Visualizar as Estatísticas relativas aos estudos, considerando as
    proporções das horas investidas nas tarefas, em relação às horas totais estudadas,
    bem como em relação às metas de cada tarefa.
</div>

<h2>Próximos Passos:</h2>
<span>
    Apesar de já trazer sua funcionalidade central, StudyPlanner funciona apenas localmente.
    Para que a aplicação possa ser distribuída como um serviço, pretende-se: 
</span>
<ol>
    <li>Criar entidades do domínio do usuário no banco de dados.</li>
    <li>Permitir que a aplicação gerencie sessões e usuários.</li>
    <li>
    Criar uma imagem Docker com a aplicação e realizar o deploy em um servidor com
    banco de dados remoto.
    </li>
    <li>Aprimorar mecanismos de segurança</li>
</ol>
<span>
    Por fim, pretende-se aprimorar de froma incremental a interface, melhorando sua
    estética com CSS e Bootstrap e adicionando comportamentos com TypeScript.
</span>
<br>
<hr>
<footer>
<small>
Gustavo Coelho Belleza Dias<br>
dias.gcb@gmail.com
</small>
</footer>
