import http.client
import json
conn = http.client.HTTPSConnection("dev-txl0aste.eu.auth0.com")

payload = "{\"client_id\":\"PqF9JqSo1tcFp3UMGpmirp1LrNMTuoMw\",\"client_secret\":\"umELSmNuo8sIdLN0H_21eIM0OBoz5y85OJKxjj7lXt9LEmgVaCTddb2eRrNOpfXX\",\"audience\":\"https://bookapi\",\"grant_type\":\"client_credentials\"}"

headers = {'content-type': "application/json"}
conn.request("POST", "/oauth/token", payload, headers)
res = conn.getresponse()
data = res.read()
print(data.decode("utf-8"))
#
data = json.loads(data.decode("utf-8"))
conn = http.client.HTTPConnection("localhost", 5000)
headers = {'authorization': f"{data['token_type']} {data['access_token']}"}
conn.request("GET", "/authentication", headers=headers)
res = conn.getresponse()
data = res.read()
print(data.decode('utf-8'))
