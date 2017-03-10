namespace WebSite.Infrastructure.Constants
{
    public static class ValidationConstants
    {
        // Email
        public const int MinLengthEmailName = 2;
        public const int MaxLengthEmailName = 200;
        public const int MinLengthEmailCompany = 2;
        public const int MaxLengthEmailCompany= 200;
        public const int MinLengthEmailSubject= 2;
        public const int MaxLengthEmailSubject= 150;
        public const int MinLengthEmailMessage= 5;
        public const int MaxLengthEmailMessage= 3500;

        // Articles
        public const int MinLengthArticleTitle = 2;
        public const int MaxLengthArticleTitle = 200;
        public const int MinLengthArticleContent = 10;
        public const int MaxLengthArticleContent = 3500;

        // TeamMembers
        public const int MinLengthTeamMemberName= 2;
        public const int MaxLengthTeamMemberName = 150;
        public const int MinLengthTeamMemberPosition = 2;
        public const int MaxLengthTeamMemberPosition = 150;
        public const int MinLengthTeamMemberDescription = 2;
        public const int MaxLengthTeamMemberDescription = 3500;

    }
}
