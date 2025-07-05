import { createRouter, createWebHistory } from 'vue-router'
import ContactComponent from '../components/ContactComponent.vue'

const routes = [
  { path: '/Contact', component: ContactComponent }
]

export default createRouter({
  history: createWebHistory(),
  routes
})
