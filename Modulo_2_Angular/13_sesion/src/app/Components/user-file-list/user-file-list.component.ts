import { Component, EventEmitter, Output } from '@angular/core';
import { UserService } from '../../Service/user.service';
import { compileNgModule } from '@angular/compiler';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-user-file-list',
  imports: [CommonModule],
  templateUrl: './user-file-list.component.html',
  styleUrl: './user-file-list.component.css'
})
export class UserFileListComponent {
  user: any[] = [];

  @Output() selecteUser = new EventEmitter();

  constructor(private userService: UserService){}

  ngOnInit(){
    this.userService.getUsers().subscribe(res -> this.user)
  }
}
