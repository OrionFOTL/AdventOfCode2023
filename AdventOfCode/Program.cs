using System.Text.RegularExpressions;

(string Name, int Value)[] numberNames =
[
    ("one", 1),
    ("two", 2),
    ("three", 3),
    ("four", 4),
    ("five", 5),
    ("six", 6),
    ("seven", 7),
    ("eight", 8),
    ("nine", 9),
    ("1", 1),
    ("2", 2),
    ("3", 3),
    ("4", 4),
    ("5", 5),
    ("6", 6),
    ("7", 7),
    ("8", 8),
    ("9", 9),
];

var sum = Input.InputString
    .Split(Environment.NewLine)
    .Select(GetFirstAndLastDigit)
    .Select(digits => digits.FirstDigit * 10 + digits.LastDigit)
    .Sum();

Console.WriteLine(sum);

(int FirstDigit, int LastDigit) GetFirstAndLastDigit(string line)
{
    var numbersPositionsAndValues = numberNames
        .SelectMany(numberName => Regex.Matches(line, numberName.Name)
            .Select(match => (PositionInLine: match.Index, Value: numberName.Value)))
        .OrderBy(n => n.PositionInLine);

    return (
        FirstDigit: numbersPositionsAndValues.First().Value,
        LastDigit: numbersPositionsAndValues.Last().Value);
}
