using Models.Configuration;

namespace Utils.LocalRun;

public class RabbitMq : LocalDependency<RabbitMqConfig>
{
    private const string ContainerName = "spotify-classic-rabbitmq-for-local-run";

    public override bool Start(RabbitMqConfig config)
    {
        if (IsDockerContainerRunning(ContainerName)) Exit();
        return RunProcess("docker", $"run -d --name {ContainerName}" + 
                             $" -e RABBITMQ_DEFAULT_USER={config.User}" +
                             $" -e RABBITMQ_DEFAULT_PASS={config.Pass}" +
                             $" -p 5672:5672 -p 15672:15672 rabbitmq:3-alpine");
    }

    public override bool Exit()
    {
        if (!IsDockerContainerRunning(ContainerName)) return true;
        return RunProcess("docker", $"stop {ContainerName}") &&
               RunProcess("docker", $"rm {ContainerName}");
    }
}