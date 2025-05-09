import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'fullname'
})
export class FullnamePipe implements PipeTransform {

  transform(user: any): string {
    return `${user.name.title} ${user.name.first} ${user.name.last}`;;
  }

}