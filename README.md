# MCUUID
**:warning: Please do not make suggestions in the issues section! If you want to suggest something then [tweet me](https://twitter.com/MCUUID/)**

## Introduction
Welcome to the MCUUID API, the API is built to be extremely simple and easily integrated.
Issues may be reported [here](https://github.com/Incrementing/MCUUID/issues)!
Please note that HTTPS will cause a hit on response times so you may want to make HTTP requests if HTTPS doesn't matter to you.

## API Limits
We limit every IP address to 200 requests a minute.
Rate limits are enforced to encourage users to make a cache of their requests to lower the stress that is put on our servers. 
JSON requests will return two variables `request_count` (the number of requests in the last minute) and `max_requests` (the max requests allowed in one minute).
The same two variables are also returned with raw TXT requests but as HTTP headers (`REQUEST_COUNT` and `MAX_REQUESTS`).

## APIs
**Full documenation can be found [here](https://mcuuid.com/docs)**

### UUID to Username
`https://api.mcuuid.com/json/name/7944c9ef-a57b-4e4f-b4b3-531d92f579da`<br>
`https://api.mcuuid.com/txt/name/7944c9ef-a57b-4e4f-b4b3-531d92f579da`<br>

### Username to UUID
`https://api.mcuuid.com/json/uuid/Incrementing`<br>
`https://api.mcuuid.com/txt/uuid/Incrementing`<br>

### UUID to Past names
`https://api.mcuuid.com/json/names/7944c9ef-a57b-4e4f-b4b3-531d92f579da`<br>
`https://api.mcuuid.com/txt/names/7944c9ef-a57b-4e4f-b4b3-531d92f579da`<br>

### Minecraft Server Ping (and Query).
`https://api.mcuuid.com/json/server/ip:game_port:query_port`<br>

### Minecraft Server Blacklist Check
`https://api.mcuuid.com/json/blacklist/*.example.com`<br>
`https://api.mcuuid.com/txt/blacklist/*.example.com`<br>

## License
The code examples are licensed under the GNU General Public License. [GNU](LICENSE)<br>
The MCUUID website and it's APIs are **not** open-source.<br>
*MCUUID is not affiliated with Minecraft, Mojang or Microsoft.*
