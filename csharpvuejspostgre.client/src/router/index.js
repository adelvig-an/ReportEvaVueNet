import { createRouter, createWebHistory } from 'vue-router'
import ReportComponent from '../components/ContactComponent.vue'

const routes = [
  { path: '/reports', component: ReportComponent }
]

export default createRouter({
  history: createWebHistory(),
  routes
})
