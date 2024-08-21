var invalidGameNumbersSummed = Input.InputString
    .Split(Environment.NewLine)
    .Select(line => line.Split(": "))
    .Select(x => new
    {
        GameNumber = int.Parse(x[0].Split(' ').Last()),
        Cubes = x[1]
            .Split("; ")
            .SelectMany(cubes => cubes
                .Split(", ")
                .Select(cubeSet => (Amount: int.Parse(cubeSet.Split(' ')[0]), Color: cubeSet.Split(' ')[1]))),
    })
    .Where(game => !game.Cubes
        .Any(cubeSet => cubeSet is { Color: "red", Amount: > 12 }
                                or { Color: "green", Amount: > 13 }
                                or { Color: "blue", Amount: > 14 }))
    .Sum(game => game.GameNumber);

Console.WriteLine(invalidGameNumbersSummed);