<h1>StudyPlanner</h1> 
C# | ASP.NET Core | Planejador Rápido de Estudos
<hr>
<h2>Intenção:</h2>
<span>
&nbsp; &nbsp; Este projeto está sendo desenvolvido com o objetivo primário de estudo
e treinamento nas ferramentas da plataforma <strong>.NET Core.</strong>
<br/><br/>
&nbsp; &nbsp; As ferramentas aqui utilizadas são aquelas que satisfazem às necessidades
de uma aplicação web, como: <strong>ASP.NET Core MVC, Entity Framework Core e C#</strong>,
como linguagem da plataforma .NET. 
<br/><br/>
&nbsp; &nbsp; Apesar do intuito didático, o StudyPlanner pretende oferecer uma funcionalidade
principal: utilizar algoritmos para organizar de forma automatizada uma rotina 
de estudos, retirando do estudando a carga cognitiva do planejamento.<br/>
</span>
&nbsp; &nbsp; No estado atual, a aplicação possui as seguintes funcionalidades:
<ul>
    <li>
    <strong>Criação de tarefas</strong> de estudo contendo Nome, Unidade/Capítulo atual, grau de prioridade de
    1 a 3 (passos de 0,5), Meta de horas de estudo e uma Descrição opcional.
    </li>
    <li>
    <strong>Lista das tarefas</strong> criadas e suas características. Bem como botões
    com a opção de Iniciar uma Sessao de Estudo, Deletar e Editar a tarefa.
    ![card image](https://github.com/gubelleza/StudyPlanner/blob/dev/CardTarefa.png)
    </li>
    <li>
    <strong>Sessões de estudo</strong> iniciadas e concluídas pelo usuário, que contabilizam
    as horas estudadas para uma determinada tarefa.
    </li>
    <li>
    <strong>Administrar a Rotina de Estudos</strong>, permitindo ao usuário atuar sobre 
    todas as tarefas existentes realizando as operações: Reiniciar, Deletar e Estabelecer
    uma meta para todas as tarefas registradas.
        <ul>
        <li>
            <strong>A funcionalidade de Estabelecer uma Meta</strong> para todas as tarefas conta com um
            algoritmo que realiza a divisão proporcional da meta de horas geral inserida
            entre as diversas tarefas, considerando como peso o grau de prioridade de 
            cada tarefa. Ex:              
            <pre><strong>/AgendaEstudos/Services/StatsService.cs</strong>
            <br>```public void AtribuirMetasProporcionais(double meta) {
                double unidadeComumHoras = meta / TotalFatorPrioridade;            
                foreach (Tarefa t in Tarefas) {
                    t.MetaHoras = t.Prioridade * unidadeComumHoras;
                    Console.WriteLine("Meta: " + t.MetaHoras);
                }
            ```}
            </pre>                        
        </li>
        </ul>   
    </li>
    <li>
        <strong>Visualizar as Estatísticas</strong> relativas aos estudos, considerando as
        proporções das horas investidas nas tarefas, em relação às horas totais estudadas,
        bem como em relação às metas de cada tarefa.
    </li>
</ul>
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
