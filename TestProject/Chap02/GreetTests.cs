using TargetProject.Chap02;
/// <summary>
/// Calculatorクラスに実装されたメソッドの単体テストドライバ
/// </summary>
namespace TestProject.Greet;

[TestClass]
public class GreetTests
{
    [TestMethod("テストケース1:朝の時間帯(代表値)ではGood Morningを返す")]
    public void AM()
    {
        // Arrange(準備)
        var greetingService = new GreetingService();
        int hour = 8;
        // Act(実行)
        var result = greetingService.Greet(hour);
        // Assert(確認)
        Assert.AreEqual("Good Morning", result);
    }

    [TestMethod("テストケース2:昼の時間帯(代表値)ではHelloを返す")]
    public void PM()
    {
        // Arrange(準備)
        var greetingService = new GreetingService();
        int hour = 13;
        // Act(実行)
        var result = greetingService.Greet(hour);
        // Assert(確認)
        Assert.AreEqual("Hello", result);
    }

    [TestMethod("テストケース3:夜の時間帯(代表値)ではGood Eveningを返す")]
    public void night()
    {
        // Arrange(準備)
        var greetingService = new GreetingService();
        int hour = 20;
        // Act(実行)
        var result = greetingService.Greet(hour);
        // Assert(確認)
        Assert.AreEqual("Good Evening", result);
    }

    [TestMethod("テストケース4:深夜・早朝(0～6時、21～23時)の場合(代表値)ではGood Nightを返す")]
    public void Add_ShouldReturnSum_WhenBothHaveValues()
    {
        // Arrange(準備)
        var greetingService = new GreetingService();
        int hour = 23;
        // Act(実行)
        var result = greetingService.Greet(hour);
        // Assert(確認)
        Assert.AreEqual("Good Night", result);
    }
}