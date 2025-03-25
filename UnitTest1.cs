namespace banko;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Account account = new Account();
        Card card = new Card(account);
        Bankomat atm = new Bankomat();
        atm.insertCard(card);

        bool result = atm.enterPin("0123");
        Assert.True(result);
    }
}
