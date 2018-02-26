import { Pipe, PipeTransform } from '@angular/core';

@Pipe({name: 'summary'})
export class SummaryPipe implements PipeTransform {
    transform(value:string, args:string[]){
        let limit:number = 20;
        if(args != null && args.length > 0)
            limit=parseInt(args[0], 10);
        
        if(value.length > limit)
            return value.substring(0, limit) + '...';
        else
            return value;
    }
}
