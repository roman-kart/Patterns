using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlixOne.InventoryManagementTests;

[TestClass]
public class FlixOneInventoryManagementInventoryTests
{
    [TestMethod]
    public void Add_AddTestItem_DatabaseMustContainsTestItem()
    {
        // создаем экземпл€р команды
        // добавл€ем новую книгу с параметром "name"
        // провер€ем, была ли добавлена книга с данным названием и кол-вом
        Assert.Inconclusive("AddCommand_Successfull has not been implemented!");
    }
    [TestMethod]
    public void Get_ElementsShouldBeReturned()
    {
        // вызываем метод дл€ получени€ всех элементов из коллекции
        // метод должен завершитьс€ без исключений
        Assert.Inconclusive("Get_ElementsShouldBeCompleteSuccessful has not been implemented");
    }
    [TestMethod]
    public void Update_ElementShouldBeUpdated()
    {
        // вызываем метод дл€ обновлени€ значений у элемента в коллекции
        // у объекта должно обновитьс€ значение
        Assert.Inconclusive("GetInventory_ElementsShouldBeCompleteSuccessful has not been implemented");
    }
}