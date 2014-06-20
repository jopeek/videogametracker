Namespace Giantbomb

    Public Class Game

        Public Property gbid As String
        Public Property name As String
        Public Property descr As String
        Public Property platforms As String
        Public Property developers As String
        Public Property publishers As String
        Public Property original_release_date As Date
        Public Property expReleaseDate As Date
        Public Property site_detail_url As String
        Public Property img_url As String
        Public Property image As Image
        Public Property lastUpdated As Date
        Public Property GamesRadarID As String
        Public Property rsslink As String

        Public Sub New()
            gbid = ""
            name = ""
            descr = ""
            platforms = ""
            developers = ""
            publishers = ""
            original_release_date = Nothing
            expReleaseDate = Nothing
            site_detail_url = ""
            img_url = ""
            image = Nothing
            lastUpdated = Nothing
            GamesRadarID = ""
            rsslink = ""
        End Sub


    End Class


End Namespace
