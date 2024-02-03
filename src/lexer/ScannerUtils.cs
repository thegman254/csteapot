namespace csteapot.lexer;

static class ScannerUtils {
    public static bool IsDigit(char c) => int.TryParse(c.ToString(), out var success);
}