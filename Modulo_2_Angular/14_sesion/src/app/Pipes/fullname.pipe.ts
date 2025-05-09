import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'fullName'
})
export class FullnamePipe implements PipeTransform {

  transform(user: any): string {
    return `${user.name.title} ${user.name.first} ${user.name.last}`;
  }

}