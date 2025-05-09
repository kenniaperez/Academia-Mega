import { Component, EventEmitter, Output } from '@angular/core';
import { UserService } from '../../Service/user.service';
import { CommonModule } from '@angular/common';
import { FullnamePipe } from '../../Pipes/fullname.pipe';

@Component({
  selector: 'app-user-file-list',
  imports: [CommonModule, FullnamePipe],
  templateUrl: './user-file-list.component.html',
  styleUrl: './user-file-list.component.css'
})
export class UserFileListComponent {
  users: any[] = [];

  @Output() selecteUser = new EventEmitter();

  constructor(private userService: UserService){}

  ngOnInit(){
    this.userService.getUsers().subscribe(res => this.users = res.results)
    console.log(this.users);
  }

  onSelect(user: any){
    this.selecteUser.emit(user)
  }
}
