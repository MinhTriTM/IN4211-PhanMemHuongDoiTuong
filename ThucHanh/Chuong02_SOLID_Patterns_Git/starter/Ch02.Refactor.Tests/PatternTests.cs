using EduHub.Ch02.Patterns.Strategies;

namespace Ch02.Refactor.Tests;

public class PatternTests
{
    [Fact]
    public void CsvReportStrategy_Render_NameContainsQuote_EscapesQuoteForCsv()
    {
        // Arrange
        var strategy = new CsvReportStrategy();
        var stats = new[] { new ClubStat("Tech, \"Makers\" Club", 1, 1, 1, 1) };

        // Act
        var csv = strategy.Render(stats);

        // Assert
        Assert.Contains("\"Tech, \"\"Makers\"\" Club\",1,1,1,1", csv);
    }
}
