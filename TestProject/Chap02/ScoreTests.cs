using TargetProject.Chap02;
/// <summary>
/// Calculatorクラスに実装されたメソッドの単体テストドライバ
/// </summary>
namespace TestProject.Score;

[TestClass]
public class ScoreServiceTests
{
    [TestMethod("テストケース1:合格点を大きく上回る場合は true を返す")]
    public void Pass()
    {
        // Arrange(準備)
        var scoreService = new ScoreService();
        int score = 80;
        // Act(実行)
        var result = scoreService.IsPassed(score);
        // Assert(確認)
        Assert.IsTrue(result);
    }

    [TestMethod("テストケース2:合格点を大きく下回る場合は false を返す")]
    public void UnPass()
    {
        // Arrange(準備)
        var scoreService = new ScoreService();
        int score = 30;
        // Act(実行)
        var result = scoreService.IsPassed(score);
        // Assert(確認)
        Assert.IsFalse(result);
    }
}