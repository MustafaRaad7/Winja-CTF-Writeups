# Cha-Cha-Cha<br />
We got a login page with **captcha**, also they provide us with **[Top 100 User List](top100usernames.txt)** , so we have to get in

## Target<br />
[\*] Bypass the captcha <br />
[\*] Brutefource login credentials <br />

## Solution<br />
the captcha was easy to bypass any orc reader can solve it  :D<br />
![](captcha.jpg)<br />
After research i got free orc reader named **Tesseract-OCR**<br />
now we have to do simple brutefource script i will provide my script below not that much efficiency but its work ^_^<br />
**Script [Link](Program.cs)**<br />
After running the script we will get the credentials<br />
**User : AURORA$JIS$UTILITY$**<br />
**Pass: AURORA$JIS$UTILITY$**<br />
now all we need login into the chall website and view page source search for the flag and yey we got it :D<br />
**flag : Flag{mSRQn7vjmiBSCBFuVJKd_not_so_effective_captcha}**<br />