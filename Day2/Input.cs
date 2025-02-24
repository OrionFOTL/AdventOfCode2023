﻿internal class Input
{
    public static string TestString = """
        Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
        Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue
        Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red
        Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red
        Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green
        """;

    public static string InputString = """
        Game 1: 3 blue, 7 green, 10 red; 4 green, 4 red; 1 green, 7 blue, 5 red; 8 blue, 10 red; 7 blue, 19 red, 1 green
        Game 2: 6 red, 10 green; 11 green, 4 red; 16 green, 2 blue; 7 green, 5 blue, 4 red; 17 green, 1 red, 1 blue
        Game 3: 5 red, 9 blue, 1 green; 5 red; 11 red, 2 green, 8 blue; 2 green, 6 blue
        Game 4: 2 red, 5 green; 2 blue, 3 red, 3 green; 3 red, 2 blue; 8 green, 2 red
        Game 5: 12 red, 13 blue; 13 blue, 2 green, 9 red; 9 blue, 1 red; 2 green, 12 blue; 1 green, 1 red, 11 blue
        Game 6: 4 blue, 11 red; 4 red; 1 green, 7 red; 1 green, 1 blue; 8 blue, 10 red; 1 green, 2 blue, 8 red
        Game 7: 7 blue, 15 red, 1 green; 5 green, 17 red, 7 blue; 5 blue, 1 green; 11 blue, 2 green, 17 red; 14 green, 9 red, 2 blue; 6 blue, 19 red
        Game 8: 13 green; 5 green; 3 blue, 9 green, 1 red; 4 red, 11 green, 4 blue
        Game 9: 4 green, 1 red, 1 blue; 4 green, 7 blue, 7 red; 9 blue, 4 red; 2 blue, 8 red, 5 green; 6 blue, 2 green; 5 red, 5 green, 10 blue
        Game 10: 1 green, 5 blue, 3 red; 4 green, 9 red, 3 blue; 11 red, 2 green, 5 blue; 3 green, 1 blue, 2 red; 6 red, 2 blue
        Game 11: 2 red, 6 green, 12 blue; 2 red, 9 blue, 1 green; 12 green, 3 blue
        Game 12: 1 red, 1 blue, 12 green; 6 green, 2 red, 1 blue; 6 red, 6 green, 1 blue; 3 green, 6 red
        Game 13: 5 red, 19 green, 3 blue; 6 red, 7 blue, 11 green; 8 blue, 6 red; 3 blue, 4 green, 4 red; 8 red, 15 green, 5 blue; 5 blue, 2 red, 10 green
        Game 14: 5 blue, 9 green; 4 green, 6 blue; 14 green, 1 red, 4 blue; 3 blue, 3 green; 2 green; 5 blue, 7 green, 1 red
        Game 15: 5 red, 8 blue; 9 blue, 3 red; 5 red, 1 green, 16 blue; 1 blue, 3 red, 2 green; 5 red, 2 green, 10 blue
        Game 16: 6 blue, 9 green, 10 red; 8 blue, 9 red, 14 green; 7 green, 1 blue, 1 red; 8 red, 5 green, 8 blue; 10 red, 5 blue, 14 green; 7 blue, 11 red, 3 green
        Game 17: 12 blue, 12 red, 6 green; 14 green, 17 blue, 4 red; 11 blue, 1 red, 13 green
        Game 18: 7 blue, 2 green, 4 red; 1 blue, 2 green, 4 red; 2 red, 17 blue
        Game 19: 3 red, 9 green; 8 red, 2 blue, 2 green; 3 blue, 15 green, 11 red; 18 green, 3 red, 1 blue
        Game 20: 5 green, 5 red, 16 blue; 8 blue, 6 green, 4 red; 10 red, 11 blue; 5 red, 5 blue, 5 green
        Game 21: 1 red, 3 blue, 14 green; 6 red, 6 blue, 17 green; 12 green, 17 blue, 3 red; 15 green, 1 red, 19 blue; 3 red, 18 blue, 4 green
        Game 22: 15 blue; 11 blue, 2 red, 1 green; 1 green, 7 red; 1 red, 18 blue, 1 green; 16 blue; 3 red, 6 blue
        Game 23: 11 blue, 6 green, 4 red; 9 green, 11 red, 8 blue; 5 green, 5 red, 2 blue; 11 green, 4 blue, 11 red; 3 green, 9 blue, 2 red
        Game 24: 7 green, 2 red; 8 red, 1 blue, 15 green; 3 red, 6 green, 6 blue
        Game 25: 9 blue, 9 green; 3 green, 7 blue, 1 red; 6 green, 1 red, 1 blue; 6 green, 1 red, 1 blue
        Game 26: 1 green, 15 blue, 1 red; 1 red, 12 blue, 1 green; 16 blue; 5 red, 11 green, 14 blue; 6 green, 4 red, 14 blue
        Game 27: 14 red, 9 green; 11 red, 5 green, 6 blue; 1 red, 6 blue, 9 green
        Game 28: 6 green, 1 blue, 9 red; 1 green, 9 red; 7 red; 11 red, 1 blue, 2 green; 8 red, 10 green; 6 green, 1 blue, 5 red
        Game 29: 1 red, 19 blue, 3 green; 9 blue, 1 red; 8 green, 17 blue; 11 blue, 4 green
        Game 30: 7 blue; 5 blue, 1 red, 1 green; 3 blue, 1 red
        Game 31: 9 red, 2 green, 1 blue; 5 red, 1 green, 3 blue; 2 green, 7 red; 2 green, 12 red
        Game 32: 1 red, 1 blue, 17 green; 14 blue, 10 green, 6 red; 12 green, 11 blue, 3 red
        Game 33: 2 red, 1 green, 3 blue; 7 blue, 4 green; 1 red, 3 green, 5 blue
        Game 34: 9 blue, 1 green, 9 red; 12 blue, 2 green, 12 red; 3 blue, 12 red; 2 green, 14 blue, 11 red; 10 red, 12 blue
        Game 35: 6 blue, 2 red; 5 blue; 6 green, 9 blue, 3 red; 3 green, 1 red, 2 blue
        Game 36: 9 blue, 4 green, 6 red; 2 red, 4 green; 7 red, 3 green; 6 green, 2 blue; 3 red, 4 blue, 3 green; 3 green, 4 red, 16 blue
        Game 37: 2 green, 8 red, 4 blue; 3 red, 4 blue, 2 green; 5 blue, 3 green; 9 blue, 15 green; 5 red, 11 green, 7 blue
        Game 38: 12 red, 1 blue; 10 red, 3 green, 2 blue; 7 blue, 3 green, 8 red; 14 red, 2 green
        Game 39: 16 green, 2 red, 17 blue; 6 red, 4 green, 13 blue; 7 blue, 1 green, 4 red; 2 green, 3 blue; 12 green, 6 red, 17 blue; 5 red, 2 blue, 6 green
        Game 40: 3 green, 4 blue, 2 red; 2 green, 3 red; 6 blue, 2 red, 6 green; 5 green; 3 blue, 1 red, 5 green
        Game 41: 13 green, 11 red; 3 green, 2 red, 1 blue; 1 blue, 3 green, 9 red; 12 red, 11 green; 9 red, 1 green; 9 green, 4 red
        Game 42: 4 green, 2 blue; 6 blue, 10 green; 13 blue, 3 red, 6 green; 11 blue, 17 green; 8 blue, 5 red
        Game 43: 10 green, 2 blue, 10 red; 3 red, 3 blue, 5 green; 10 green, 11 red, 4 blue; 5 green; 7 green, 13 red, 2 blue
        Game 44: 4 red, 1 blue, 5 green; 1 blue, 8 red, 3 green; 11 red, 1 green, 1 blue; 2 green, 12 red, 1 blue; 1 blue, 12 red; 14 red, 3 green
        Game 45: 4 green, 5 red, 7 blue; 10 red, 8 green, 3 blue; 12 blue, 1 green, 13 red; 1 red, 3 blue, 7 green
        Game 46: 5 blue, 13 red; 15 red, 3 green, 17 blue; 8 red, 2 green, 1 blue; 1 green, 7 red, 16 blue; 4 blue, 10 red
        Game 47: 2 red, 3 green; 2 blue, 9 red, 15 green; 7 green, 4 red; 3 blue, 13 red, 9 green
        Game 48: 11 green, 4 red, 9 blue; 1 blue, 7 green; 4 blue, 4 red; 4 red, 4 blue, 2 green; 9 green, 2 blue, 2 red
        Game 49: 10 green, 6 blue; 2 blue, 5 green, 1 red; 5 green, 4 blue; 11 green, 3 red, 3 blue
        Game 50: 2 red, 15 green, 1 blue; 8 green, 7 blue; 4 blue, 8 green; 7 blue, 17 green; 5 blue, 6 green, 2 red; 16 green, 2 red, 1 blue
        Game 51: 3 green, 5 blue, 1 red; 11 red, 9 blue, 8 green; 3 red, 8 green, 7 blue; 1 red, 9 blue, 6 green; 4 green, 1 red, 3 blue; 8 green, 7 red
        Game 52: 1 green, 2 blue, 10 red; 8 green, 1 blue, 2 red; 7 red, 8 green
        Game 53: 2 red, 6 green; 1 green, 4 blue; 12 green, 19 blue; 11 blue, 1 green; 4 green, 20 blue; 7 blue, 9 green, 1 red
        Game 54: 2 blue, 2 green, 2 red; 13 red, 1 green, 6 blue; 9 blue, 1 green, 18 red; 11 red, 16 blue; 15 red, 3 green, 13 blue
        Game 55: 5 green, 5 blue, 9 red; 8 red, 11 blue, 7 green; 6 green, 2 red, 10 blue; 6 red, 6 blue, 9 green; 11 green, 14 blue, 4 red
        Game 56: 8 blue, 14 green; 3 red, 8 green, 3 blue; 14 green, 1 red, 13 blue; 8 green, 3 red; 8 blue, 11 green, 1 red; 8 blue, 10 green, 2 red
        Game 57: 7 blue, 7 red; 11 green, 5 blue, 2 red; 14 green, 8 blue; 5 blue, 2 red, 17 green; 12 green, 3 red; 7 red, 7 blue, 9 green
        Game 58: 3 blue, 4 red, 1 green; 2 green, 3 red; 1 red, 2 green, 4 blue; 4 green, 4 red, 2 blue
        Game 59: 6 red, 4 blue, 5 green; 6 blue, 6 red; 1 red; 8 blue, 1 red
        Game 60: 4 blue, 9 green, 11 red; 12 green, 3 red, 9 blue; 7 green, 1 blue; 14 green, 11 blue, 11 red
        Game 61: 12 green; 9 green, 9 red; 12 red, 18 blue, 8 green; 16 red, 10 blue, 3 green; 6 green, 15 red, 3 blue; 13 green
        Game 62: 2 green, 3 red, 12 blue; 12 blue, 12 green, 12 red; 1 red, 12 blue, 5 green; 7 red, 9 blue, 13 green; 1 blue, 3 red, 10 green; 2 blue, 8 red, 17 green
        Game 63: 10 green, 7 blue, 4 red; 3 blue, 6 green, 2 red; 4 green, 10 red, 6 blue; 16 blue, 5 red, 4 green
        Game 64: 11 red, 1 green, 6 blue; 12 red, 3 green; 6 green, 5 blue, 2 red; 4 green, 9 blue, 11 red; 5 blue, 8 green, 8 red; 9 green, 11 blue
        Game 65: 4 blue, 12 red; 1 green, 3 blue, 12 red; 1 green, 3 blue, 13 red; 2 red; 12 red
        Game 66: 4 red, 3 green, 3 blue; 2 blue, 4 red; 10 red, 6 blue, 3 green
        Game 67: 7 red, 2 blue, 5 green; 3 green, 5 red, 18 blue; 16 red, 5 green, 13 blue; 16 red, 5 blue, 2 green
        Game 68: 11 blue, 2 red; 1 green, 3 blue, 8 red; 16 red, 1 green, 17 blue; 4 red, 1 green, 11 blue; 3 red
        Game 69: 1 green, 9 red, 12 blue; 12 red; 11 blue; 1 green
        Game 70: 1 green, 18 blue, 16 red; 3 green, 15 red, 7 blue; 3 blue, 3 green, 10 red; 1 blue, 3 green, 10 red
        Game 71: 3 red, 12 blue, 8 green; 18 green, 12 blue, 5 red; 2 blue, 7 red; 11 blue, 9 green; 5 blue, 7 red, 19 green; 2 red, 1 blue, 13 green
        Game 72: 8 red, 6 blue, 3 green; 2 green, 13 blue, 15 red; 5 green, 8 blue, 2 red; 5 red, 12 blue, 3 green
        Game 73: 3 blue, 13 green; 7 red, 3 green; 10 red, 2 blue, 1 green
        Game 74: 3 red; 2 red, 1 blue, 7 green; 10 green, 3 blue, 1 red; 6 green, 1 blue; 11 green, 4 blue
        Game 75: 8 blue, 2 green, 4 red; 19 blue, 2 green; 1 red, 18 blue, 3 green; 3 red, 5 green, 18 blue
        Game 76: 3 green, 2 red, 2 blue; 3 blue, 6 green, 1 red; 1 green, 3 blue; 1 blue, 1 green
        Game 77: 4 green, 7 red, 13 blue; 18 blue; 4 blue, 9 red, 1 green; 2 green, 16 blue, 9 red
        Game 78: 2 green, 5 blue, 11 red; 2 blue, 3 red, 1 green; 4 green, 6 blue, 6 red
        Game 79: 9 blue, 1 green, 3 red; 1 green, 2 red, 4 blue; 5 red, 4 green, 10 blue; 1 red, 9 blue, 4 green
        Game 80: 8 red, 5 green, 7 blue; 15 red, 6 blue, 8 green; 8 blue, 14 red, 7 green; 3 blue, 2 green, 20 red; 10 red, 8 blue, 1 green; 7 green, 11 red, 9 blue
        Game 81: 7 red, 1 blue, 5 green; 5 green, 10 blue, 9 red; 8 blue, 2 green, 7 red
        Game 82: 1 green, 6 blue, 14 red; 7 blue, 2 green; 7 blue, 17 red, 3 green
        Game 83: 2 red, 19 blue, 2 green; 5 red, 5 blue, 2 green; 2 red, 4 blue, 1 green
        Game 84: 1 blue, 1 red, 12 green; 11 blue, 6 red, 13 green; 10 red, 8 blue, 8 green; 14 blue, 15 red; 19 blue, 10 green, 17 red; 11 red, 7 green
        Game 85: 16 blue, 12 red, 8 green; 13 red, 3 green; 1 red, 16 blue, 10 green
        Game 86: 5 green, 8 blue, 3 red; 8 green, 9 red, 13 blue; 4 green, 1 red, 12 blue; 13 red, 15 blue, 5 green
        Game 87: 1 green, 16 red; 10 red, 2 green, 2 blue; 16 red, 5 blue; 1 blue, 2 green
        Game 88: 3 blue, 1 green; 1 red, 2 green, 13 blue; 5 blue, 2 green, 1 red
        Game 89: 9 blue, 2 red, 1 green; 10 blue; 5 blue, 1 green
        Game 90: 8 red, 2 blue, 5 green; 2 red, 2 green, 2 blue; 1 blue, 8 green, 10 red; 11 green, 1 blue; 10 green, 4 red, 3 blue
        Game 91: 14 blue, 9 red; 5 green, 5 red, 11 blue; 7 green, 4 blue, 12 red; 8 red, 6 green, 10 blue
        Game 92: 2 green, 2 blue, 12 red; 2 green, 1 blue, 14 red; 14 red, 2 blue, 6 green; 11 red, 6 green, 2 blue; 11 green, 12 red, 2 blue
        Game 93: 4 green, 7 blue, 3 red; 1 green, 12 blue, 1 red; 8 blue, 7 green, 2 red; 3 red, 9 blue, 2 green
        Game 94: 13 green, 9 blue; 9 blue, 1 red, 8 green; 12 green, 1 red, 8 blue; 1 red, 9 green; 1 red, 5 blue, 14 green
        Game 95: 7 blue, 14 red; 9 blue, 17 red; 2 blue, 1 green, 4 red
        Game 96: 11 blue, 2 green, 3 red; 3 blue, 12 red, 3 green; 4 green, 11 red, 1 blue
        Game 97: 9 red, 5 green, 2 blue; 12 red, 1 blue, 11 green; 7 green, 4 red, 2 blue; 1 blue, 6 red, 10 green
        Game 98: 5 green, 5 red, 11 blue; 1 red, 10 blue, 7 green; 8 red, 1 blue, 7 green; 8 green, 11 red, 2 blue; 4 red, 5 blue, 2 green; 10 green, 5 red, 9 blue
        Game 99: 3 green, 7 red, 4 blue; 9 red, 13 blue, 2 green; 3 red, 2 green, 11 blue; 5 red, 6 blue, 3 green; 8 blue, 5 green, 6 red; 6 green, 13 red, 1 blue
        Game 100: 9 green, 7 blue; 1 green, 3 red, 4 blue; 15 red, 9 green; 3 blue, 6 red, 13 green; 2 red, 11 blue, 12 green
        """;
}
