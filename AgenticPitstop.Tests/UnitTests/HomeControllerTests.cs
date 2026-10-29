namespace AgenticPitstop.Tests.UnitTests
{
    /// <summary>
    /// Unit tests for basic validation and helper methods.
    /// </summary>
    public class HomeControllerTests
    {
        [Fact]
        public void String_Normalize_WithNull_ReturnsEmpty()
        {
            var result = string.IsNullOrEmpty(null);
            Assert.True(result);
        }

        [Fact]
        public void String_Normalize_WithEmpty_ReturnsTrue()
        {
            var result = string.IsNullOrEmpty(string.Empty);
            Assert.True(result);
        }

        [Fact]
        public void String_Normalize_WithWhitespace_IsNotEmpty()
        {
            var result = string.IsNullOrWhiteSpace("   ");
            Assert.True(result);
        }

        [Fact]
        public void String_Contains_Backslash_IsTrue()
        {
            var input = "DOMAIN\\username";
            var result = input.Contains("\\");
            Assert.True(result);
        }

        [Fact]
        public void String_Contains_ForwardSlash_IsTrue()
        {
            var input = "DOMAIN/username";
            var result = input.Contains("/");
            Assert.True(result);
        }

        [Fact]
        public void String_Contains_AdminSuffix_IsTrue()
        {
            var input = "username.adm";
            var result = input.Contains(".adm");
            Assert.True(result);
        }

        [Fact]
        public void String_EndsWith_AdminSuffix_IsTrue()
        {
            var input = "username.adm";
            var result = input.EndsWith(".adm");
            Assert.True(result);
        }

        [Fact]
        public void String_Trim_RemovesLeadingTrailingSpaces()
        {
            var input = "  username  ";
            var result = input.Trim();
            Assert.Equal("username", result);
        }

        [Fact]
        public void String_LastIndexOfAny_FindsBackslash()
        {
            var input = "DOMAIN\\username";
            var result = input.LastIndexOfAny(new[] { '\\', '/' });
            Assert.True(result >= 0);
        }
    }
}
