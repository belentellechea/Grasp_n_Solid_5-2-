namespace Full_GRASP_And_SOLID
{
    /*
    para eliminar la dependencia entre la clase ConsolePrinter con la clase Recipe, se debe generar una abstracción entre ellas 
    con respecto al método que ambas implementan. Para esto, se aplica el principio DIP (Dependency Inversion Principle)
    */
    public interface IRecipeText
    {
        string GetTextToPrint();
    }
}