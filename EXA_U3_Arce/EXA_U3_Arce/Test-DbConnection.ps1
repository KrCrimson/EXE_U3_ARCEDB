$connectionString = "Data Source=.\MSSQLSERVER1;Initial Catalog=EXA_U3_ArceDB;Integrated Security=True"
try {
    $conn = New-Object System.Data.SqlClient.SqlConnection($connectionString)
    $conn.Open()
    Write-Host "Connection Successful!" -ForegroundColor Green
    $conn.Close()
}
catch {
    Write-Host "Connection Failed!" -ForegroundColor Red
    Write-Host $_.Exception.Message
    Write-Host $_.Exception.InnerException
}
