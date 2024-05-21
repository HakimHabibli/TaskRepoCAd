 git pull

    set "year=%date:~10,4%"
    set "month=%date:~4,2%"
    set "day=%date:~7,2%"
    set "hour=%time:~0,2%"
    set "minute=%time:~3,2%"
    set "second=%time:~6,2%"
    set "datestamp=%year%-%month%-%day%-%hour%-%minute%-%second%"


    git add .
    git commit -m "New Code Added or updated" -m "some changes to the code base : %datestamp%"  
    git push 