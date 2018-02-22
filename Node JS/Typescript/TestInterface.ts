interface ICustomer
{
    firstName :string;
    lastName? : string;
    moneySpend: number;
}


    function print(customers:ICustomer[]){
        for(let c of customers){
            console.log(c);
        }
    };

    print([{fistName :"Brijesh",lastName:"Yadav",moneySpend:200},{firstName: "Aakash",lastName:"Malaviya",moneySpend:300},{firstName: "Himanshu",moneySpend:400}])