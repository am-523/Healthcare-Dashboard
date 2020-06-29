Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CartesianChart1.Series = New SeriesCollection From {
              New LineSeries With {
                  .Values = New ChartValues(Of ObservablePoint) From {
                        New ObservablePoint(0, 4),
                        New ObservablePoint(5, 5),
                        New ObservablePoint(7, 7),
                        New ObservablePoint(9, 10),
                        New ObservablePoint(10, 9)
                    },
                    .PointGeometrySize = 15
                  }
                  }

    End Sub


End Class
