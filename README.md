# Crisis Wordlist Generator

Work on Windows, Debian and Kali Linux. 

# Install in Linux

Warning, install mono before.

* Install Crisis Wordlist Generator in Linux

# Donations : Crisis Wordlist Generator

If you like this project, you can contribute by a donation :smile:

Need a new option, donate and make your request.

Bitcoin : 1NmgotukmYRoBxx3BFHPxVZGdPhDwoerRh

# Run
<pre style=" border: 1px solid black; padding:10px">
root@kali:~# crisis 
</pre>

# Manual

<pre style=" border: 1px solid black; padding:10px">
root@kali:~# crisis -h
</pre>

#Usage

<h2>Pipe with crisis and Aircrack-ng</h2>

<pre style=" border: 1px solid black; padding:10px">
./crisis.exe -3 -l 20  -f lalpha-numeric | aircrack-ng -w- -e BOX__XXXX output-01.cap 
Opening output-01.cap
Opening output-01.cap
Reading packets, please wait...

                                 Aircrack-ng 1.2 rc2


                   [00:11:20] 1268865 keys tested (1870.62 k/s)


                       Current passphrase: 3e4u74mem30uf1sso47p       


      Master Key     : DF 02 B4 54 4A A5 43 FE BC 5E 09 AB 3C B6 33 70 
                       7E 4A 78 50 4E AA B2 4B C2 C8 3A 1F 31 FC A6 5A 

      Transient Key  : EF AD 2F 48 64 03 60 73 3A 34 03 D9 D3 1D DD B5 
                       F3 F0 1C EF 7C 36 15 6B 57 4C 43 3B 64 40 30 F5 
                       9F 35 70 36 C8 6F E7 E7 71 BE 01 42 96 A0 90 33 
                       2B B9 CF 3B 1B B5 27 AA 75 14 D1 4E 09 70 EF F4 

      EAPOL HMAC     : A1 F8 50 CD C8 32 F6 6B C2 86 0B 58 40 B7 3D 24
</pre>

<h2>Pipe with crisis and genpmk</h2>

<pre style=" border: 1px solid black; padding:10px">
crisis -3 -l 20 -f lalpha | genpmk -f- -d wordlistBOX -s BOX_XXXX
genpmk 1.1 - WPA-PSK precomputation attack. <jwright@hasborg.com>
Using STDIN for words.
File wordlistSFR does not exist, creating.
key no. 1000: negdhirvdowoyodenjta
key no. 2000: pggcdhupteltboqnzvac
key no. 3000: sxtpwjrcegzmpskultzy
key no. 4000: gwifxtqfvvsttvuowmii
key no. 5000: xxmvqajwzjoyglotainh
key no. 6000: xefzswiqrzcqsbqncugu
key no. 7000: cmuxxhwtbyskclxzlbdq
key no. 8000: fhmegcamdtbwwbvfvdsj
key no. 9000: yeonrqsrvllbdfyvuuqc
key no. 10000: kgrzzjqshhbangsfqezm
^C
10470 passphrases tested in 26.96 seconds:  388.38 passphrases/second
</pre>

<h2>Pipe with crisis, pyrit and cowpatty</h2>

<pre style=" border: 1px solid black; padding:10px">
crisis -3 -l 26 -f hex-upper -u | pyrit -o- -i- -e Box-007  passthrough | cowpatty -d - -r wpa-01.cap -s Box-007
cowpatty 4.6 - WPA-PSK dictionary attack. <jwright@hasborg.com>

Collected all necessary data to mount crack against WPA2/PSK passphrase.
Starting dictionary attack.  Please be patient.
Using STDIN for hashfile contents.
key no. 10000: 4D56FE1B55760FC46DE93AA031
key no. 20000: 0C0BE442CBB59420F59A145740
key no. 30000: 3928A1CB5B8CA1DE6AA93A4ACD
key no. 40000: 1569AAA92000E811B3CE9A51E1
key no. 50000: C4A6FEAEB70A2A604EB398E3C8
key no. 60000: A0C4C968E3F4DC885505A72CCC
key no. 70000: F356768829B8375B25171E1475
key no. 80000: AD94375F47EC46AD0F8A1198A1
key no. 90000: 371A4C1D60D765AF034B94573D
key no. 100000: 1B07C34533B4BC7EBC5032F93E
key no. 110000: F6E244DFFDF2D8DFA8E32227E6
key no. 120000: B883286C8F737B2EDDD26A4D67
key no. 130000: 2B4A13BFACAE8306AB58046C6C
key no. 140000: E9994E0CFE374D74713EEC3716
key no. 150000: 7448B93813CEEF66950B47F53A
key no. 160000: 9CF4636D6E82F78F66D0459D94
key no. 170000: D6EE9AF334F1993C2C52BC11FF
key no. 180000: E3E64D04204B9BE3F13C12C0F8
</pre>
