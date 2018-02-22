let printer= (msg) => console.log(msg);

printer("Hello Brijesh");
printer("Hello Akash");

function getData(fn)
{
    let no = (Math.random()*10);

    if(no > 5)
    {
        fn({result:"Success " + no});
    }
    else
    {
        fn({result:"Error" + no});
    }
}

getData((r)=> console.log(r.result));

getData((r)=> console.log(r));

setTimeout(()=> {getData((r)=> {console.log("into timeout");
                                console.log(r);})} ,3000);