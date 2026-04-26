using FreelancePlatform.Domain.Entities;
using FreelancePlatform.Domain.Enums;
using FreelancePlatform.ValueObjects.Objects;

try
{
    Console.WriteLine("ДЕМО ФРИЛАНС-БИРЖИ\n");


    // создание пользователей


    var client = new User(
        1,
        new UserName("Алексей"),
        new Email("alex@mail.com"),
        new PasswordHash("client_hash"),
        UserRole.Client);

    var freelancer = new User(
        2,
        new UserName("Иван"),
        new Email("ivan@mail.com"),
        new PasswordHash("free_hash"),
        UserRole.Freelancer);

    Console.WriteLine("Пользователи созданы:");
    Console.WriteLine($"Заказчик: {client.Name.Value}");
    Console.WriteLine($"Исполнитель: {freelancer.Name.Value}\n");

    // добавление навыков исполнителю

    freelancer.AddSkill(new Skill(1, new Title("C#")));
    freelancer.AddSkill(new Skill(2, new Title(".NET")));
    freelancer.AddSkill(new Skill(3, new Title("SQL Server")));

    Console.WriteLine("Навыки исполнителя:");

    foreach (var skill in freelancer.Skills)
        Console.WriteLine($"- {skill.Name.Value}");

    Console.WriteLine();


    // портфолио


    freelancer.AddPortfolioItem(
        new PortfolioItem(
            1,
            new Title("CRM система"),
            new Description("Разработка корпоративной CRM"),
            new ImageUrl("https://site.com/crm.jpg")));

    freelancer.AddPortfolioItem(
        new PortfolioItem(
            2,
            new Title("Интернет-магазин"),
            new Description("Онлайн магазин одежды"),
            new ImageUrl("https://site.com/shop.jpg")));

    Console.WriteLine("Портфолио исполнителя:");

    foreach (var item in freelancer.Portfolio)
        Console.WriteLine($"- {item.Title.Value}");

    Console.WriteLine();

    // создание заказа


    var order = new Order(
        1,
        client,
        new Title("Разработка сайта"),
        new Description("Нужен сайт компании с админ-панелью"),
        new Money(1500m),
        new CategoryName("Web Development"));

    Console.WriteLine("Создан заказ:");
    Console.WriteLine($"#{order.Id} {order.Title.Value}");
    Console.WriteLine($"Бюджет: {order.Budget.Value}$");
    Console.WriteLine($"Категория: {order.Category.Value}\n");


    // отклик на заказ


    var proposal = new Proposal(
        1,
        order,
        freelancer,
        new Description("Готов выполнить за 10 дней."),
        new Money(1400m));

    order.AddProposal(proposal);

    Console.WriteLine("Исполнитель отправил отклик:");
    Console.WriteLine($"{freelancer.Name.Value}: {proposal.ProposedPrice.Value}$");
    Console.WriteLine();

    // заказчик принимает отклик

    var contract = order.AcceptProposal(proposal, 1);

    Console.WriteLine("Отклик принят.");
    Console.WriteLine($"Создан контракт #{contract.Id}");
    Console.WriteLine();

    // завершение заказа
    
    contract.Complete();

    Console.WriteLine("Контракт завершен.");
    Console.WriteLine();

    // отзывы

    var reviewForFreelancer = new Review(
        1,
        contract,
        client,
        freelancer,
        5,
        new ReviewComment("Отличная работа, все вовремя."));

    freelancer.AddReview(reviewForFreelancer);

    var reviewForClient = new Review(
        2,
        contract,
        freelancer,
        client,
        5,
        new ReviewComment("Четкое ТЗ и быстрая оплата."));

    client.AddReview(reviewForClient);

    Console.WriteLine("Отзывы добавлены.\n");

    // просмотр отзывов
    

    Console.WriteLine("Отзывы об исполнителе:");

    foreach (var review in freelancer.Reviews)
        Console.WriteLine($"- {review.Rating}/5 | {review.Comment.Value}");

    Console.WriteLine();

    Console.WriteLine("Отзывы о заказчике:");

    foreach (var review in client.Reviews)
        Console.WriteLine($"- {review.Rating}/5 | {review.Comment.Value}");

    Console.WriteLine();


    // рейтинг


    Console.WriteLine("Рейтинг пользователей:");
    Console.WriteLine($"{client.Name.Value}: {client.Rating}");
    Console.WriteLine($"{freelancer.Name.Value}: {freelancer.Rating}");

    Console.WriteLine(" Демонстрация завершена успешно.");

}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ошибка:");
    Console.WriteLine(ex.Message);
    Console.ResetColor();
}

Console.WriteLine("\nНажмите любую клавишу чтобы закончить");
Console.ReadKey();