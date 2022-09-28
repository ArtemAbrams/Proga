using Task_2;

Manager manager = new Manager("Artem");
Developer developer = new Developer("Adolf");
Team team = new Team("Osvald");
team.AddWorker(manager);
team.AddWorker(developer);
Team.displayInform(team);
