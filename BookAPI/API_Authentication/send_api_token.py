import http.client

conn = http.client.HTTPConnection("http://localhost:5001")

headers = {'authorization': "Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCIsImtpZCI6Im9BRnJPSWIwZ01EMHE1LU1RVzBCNyJ9.eyJpc3MiOiJodHRwczovL2Rldi10eGwwYXN0ZS5ldS5hdXRoMC5jb20vIiwic3ViIjoiUDJWQnl4SVhtdGtFS0lmbU94bk8wbDIzajUzYXZEY3FAY2xpZW50cyIsImF1ZCI6Imh0dHBzOi8vd2VlcmFwaWRlbW8iLCJpYXQiOjE2MTk1Mjc2MzYsImV4cCI6MTYxOTYxNDAzNiwiYXpwIjoiUDJWQnl4SVhtdGtFS0lmbU94bk8wbDIzajUzYXZEY3EiLCJndHkiOiJjbGllbnQtY3JlZGVudGlhbHMifQ.n9vRqmFkiQq6da6XOg7ADuJXPaK8c3LqScunGUUIsnV8UlYpVK5b7FFJw5ckri8uawl_74rZBbGBzy55COpIR2SPbOBL4TBH5RWPyAKKEZAR0g-L15Bag5GsldRO8bc1IfgXfnOVIfmz_E3f9ngOaZwYzE4Un7RcoNWxK9GNp3oE5vKauPwM7eHkYj8vRdC53DJn4OPB9fk0JaThEYtlwWB5qSPAd2L9Jhe70QS1NI80nlymR54lzw65ux7m2QV3hEHubK9OUdO2kqrfjCYKQTEGVpSFR-DMTZAPukXza6xwX1IgCjd2L4l71WACWskRBItb94X1gVaZ76ntdztx6w"}

conn.request("GET", "/authentication", headers=headers)

res = conn.getresponse()
data = res.read()

print(data.decode("utf-8"))
