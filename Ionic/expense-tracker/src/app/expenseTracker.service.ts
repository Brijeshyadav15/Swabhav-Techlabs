import { Injectable } from "@angular/core";

@Injectable()
export class ExpenseTracker{

    categories = [
        {
        "id":1,
        "name":"Travel"
        },
        {
            "id":2,
            "name":"Food"
        },
        {
            "id":3,
            "name":"Entertainment"
        },
        {
            "id":4,
            "name":"Rent"
        },
        {
            "id":5,
            "name":"Other"
        }
    ];

    expenses=[
            { 
                "id":1,
                "cost":100,
                "description":"Travel from Office to Home",
                "category" : "Travel",
                "date" : "21/02/2018"
            },
            { 
                "id":2,
                "cost": 250,
                "description":"Lunch on 21/02/2018",
                "category" : "Food",
                "date" : "21/02/2018"
            },
            { 
                "id":3,
                "cost":150,
                "description":"Movie Tickets",
                "category" : "Entertainment",
                "date" : "21/02/2018"
            },
            { 
                "id":4,
                "cost":50,
                "description":"Snacks at Movie",
                "category" : "Other",
                "date" : "21/02/2018"
            },
            { 
                "id":5,
                "cost":2000,
                "description":"Hotel Rent",
                "category" : "Rent",
                "date" : "21/02/2018"
            }
    ];


    ExpenseTracker(){
        localStorage.setItem('expenses',JSON.stringify(this.expenses));
        let ex= localStorage.getItem('expenses');
        console.log(ex);
    }

    

    getCategories(){
        return JSON.stringify(this.categories);
    }

    getExpenses(){
        return JSON.stringify(this.expenses);
    }

    getExpensesById(id){
        for(let e of this.expenses){
            if(e.id == id)
                return JSON.stringify(e)
        }
    }

    getCategoriesById(id){
        return this.categories[id];
    }

    deleteExpense(id){
        let expense:any;
        for(let ex of this.expenses){
            if(ex.id ==id){
                expense = ex;
            }
        }
        this.expenses.splice(expense);
    }

    updateExpense(expense){
        for(let ex of this.expenses){
            if(ex.id == expense.id){
                this.expenses.splice(ex.id);
            }
        }
        this.expenses.push(expense);
    }
}