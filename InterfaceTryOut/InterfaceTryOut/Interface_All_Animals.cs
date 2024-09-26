namespace InterfaceTryOut;

public interface IAnimal
{
    void Eat();
    string GetSpecies();
}
public interface IPrey
{
    void Flee();
}

public interface IPredator
{
    void Hunt();
}
