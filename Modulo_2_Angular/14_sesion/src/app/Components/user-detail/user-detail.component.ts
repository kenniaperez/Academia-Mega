import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';
import { FullnamePipe } from '../../Pipes/fullname.pipe';

@Component({
  selector: 'app-user-detail',
  imports: [CommonModule, FullnamePipe],
  templateUrl: './user-detail.component.html',
  styleUrl: './user-detail.component.css'
})
export class UserDetailComponent {
 @Input() user:any; 
}
