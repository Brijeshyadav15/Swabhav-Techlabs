import { reject } from "q";

export class MathService{
    checkIsPrime(no)
    {
        let p = new Promise((resolve,reject)=>{
            let flag:number =0 ;
            for(let i=2; i<=no/2; ++i)
            {
                if(no%i==0)
                {
                    flag =1;                        
                    resolve(0);
                    break;
                }
            }
            if(flag == 0)          
            {
                resolve(1);
            }
        });
        return p;
    }
}