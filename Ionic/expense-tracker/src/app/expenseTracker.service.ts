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
    expenses:any;

    getCategories(){        
        return this.categories;
    }

    getExpenses(){
        this.expenses =JSON.parse(localStorage.getItem('expenses')) != null  ?JSON.parse(localStorage.getItem('expenses')) : [''];
        console.log(this.expenses);
        //console.log(this.expenses.length);
        return this.expenses;
    }

    saveExpenses(){        
        localStorage.setItem('expenses',JSON.stringify(this.expenses));
    }

    saveCategories(){
        localStorage.setItem('categories',JSON.stringify(this.categories));
    }

    addExpense(ex){
        this.expenses.push(ex);
        this.saveExpenses();
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
        let val = this.expenses.indexOf(expense);
        if(val >-1)
        {
            this.expenses.splice(val,1);
        }        
        this.saveExpenses();
    }

    updateExpense(expense){
        let exp :any
        for(let ex of this.expenses){
            if(ex.id == expense.id){
                expense = ex;
            }
        }

        let val = this.expenses.indexOf(exp);
        if(val >-1){
            this.expenses.splice(val,1);
        }        
        this.expenses.push(expense);
        this.saveExpenses();
    }
}

