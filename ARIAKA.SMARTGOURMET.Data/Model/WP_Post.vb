Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Model
    <Table("bdmaratontpa.wp_posts")>
    Public Class WP_Posts
        <Key>
        Public Property ID As Integer
        Public Property post_type As String
        Public Property post_content As String
    End Class
End Namespace
