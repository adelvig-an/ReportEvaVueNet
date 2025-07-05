<template>
  <div class="contact-manager">
    <h1>Contact Management</h1>

    <form @submit.prevent="saveContact" class="contact-form">
      <h2>{{ editingContact.id ? 'Edit Contact' : 'Add New Contact' }}</h2>
      <div class="form-group">
        <label for="surname">Surname:</label>
        <input type="text" id="surname" v-model="editingContact.surname" required />
      </div>
      <div class="form-group">
        <label for="name">Name:</label>
        <input type="text" id="name" v-model="editingContact.name" required />
      </div>
      <div class="form-group">
        <label for="patronymic">Patronymic:</label>
        <input type="text" id="patronymic" v-model="editingContact.patronymic" />
      </div>
      <div class="form-group">
        <label for="email">Email:</label>
        <input type="email" id="email" v-model="editingContact.email" />
      </div>
      <div class="form-group">
        <label for="phone">Phone:</label>
        <input type="tel" id="phone" v-model="editingContact.phone" />
      </div>
      <button type="submit" class="save-button">
        {{ editingContact.id ? 'Update Contact' : 'Add Contact' }}
      </button>
      <button type="button" @click="cancelEdit" v-if="editingContact.id" class="cancel-button">
        Cancel
      </button>
    </form>

    <hr />

    <h2>My Contacts</h2>
    <p v-if="contacts.length === 0">No contacts yet. Add one above!</p>
    <ul class="contact-list">
      <li v-for="contact in contacts" :key="contact.id" class="contact-item">
        <div class="contact-details">
          <strong>{{ contact.surname }} {{ contact.name }} {{ contact.patronymic }}</strong>
          <p v-if="contact.email">Email: {{ contact.email }}</p>
          <p v-if="contact.phone">Phone: {{ contact.phone }}</p>
          <p class="created-at">Created At: {{ new Date(contact.createdAt).toLocaleDateString() }}</p>
        </div>
        <div class="contact-actions">
          <button @click="editContact(contact)" class="edit-button">Edit</button>
          <button @click="deleteContact(contact.id)" class="delete-button">Delete</button>
        </div>
      </li>
    </ul>
  </div>
</template>

<script setup>
  import { ref } from 'vue';

  // Reactive state for contacts and the contact being edited
  const contacts = ref([]);
  const editingContact = ref(createEmptyContact());

  // Helper to create an empty contact object
  function createEmptyContact() {
    return {
      id: 0,
      name: '',
      patronymic: '',
      surname: '',
      email: '',
      phone: '',
      createdAt: new Date().toISOString(), // Use ISO string for consistency
    };
  }

  // Simulate a unique ID generator
  let nextId = 1;

  // --- CRUD Operations ---

  // Save or Update a Contact
  function saveContact() {
    if (editingContact.value.id) {
      // Update existing contact
      const index = contacts.value.findIndex(c => c.id === editingContact.value.id);
      if (index !== -1) {
        contacts.value[index] = { ...editingContact.value };
        console.log('Contact updated:', editingContact.value);
      }
    } else {
      // Add new contact
      editingContact.value.id = nextId++;
      editingContact.value.createdAt = new Date().toISOString(); // Set creation time for new contacts
      contacts.value.push({ ...editingContact.value });
      console.log('New contact added:', editingContact.value);
    }
    resetForm();
  }

  // Set contact for editing
  function editContact(contact) {
    editingContact.value = { ...contact }; // Create a copy to avoid direct mutation
  }

  // Delete a Contact
  function deleteContact(id) {
    if (confirm('Are you sure you want to delete this contact?')) {
      contacts.value = contacts.value.filter(c => c.id !== id);
      console.log('Contact deleted with ID:', id);
      resetForm(); // Reset form in case the deleted contact was being edited
    }
  }

  // Clear the form
  function resetForm() {
    editingContact.value = createEmptyContact();
  }

  // Cancel editing
  function cancelEdit() {
    resetForm();
  }

  // --- Initial Data (Optional) ---
  // You can populate some initial data for testing
  contacts.value = [
    { id: nextId++, name: 'John', patronymic: '', surname: 'Doe', email: 'john.doe@example.com', phone: '123-456-7890', createdAt: new Date().toISOString() },
    { id: nextId++, name: 'Jane', patronymic: 'Marie', surname: 'Smith', email: 'jane.smith@example.com', phone: '098-765-4321', createdAt: new Date().toISOString() },
  ];
</script>

<style scoped>
  .contact-manager {
    max-width: 800px;
    margin: 20px auto;
    padding: 20px;
    border: 1px solid #ccc;
    border-radius: 8px;
    font-family: sans-serif;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
  }

  h1, h2 {
    color: #333;
    text-align: center;
    margin-bottom: 20px;
  }

  hr {
    border: 0;
    height: 1px;
    background: #eee;
    margin: 30px 0;
  }

  /* Form Styles */
  .contact-form {
    background-color: #f9f9f9;
    padding: 20px;
    border-radius: 8px;
    margin-bottom: 30px;
  }

  .form-group {
    margin-bottom: 15px;
  }

    .form-group label {
      display: block;
      margin-bottom: 5px;
      font-weight: bold;
      color: #555;
    }

    .form-group input[type="text"],
    .form-group input[type="email"],
    .form-group input[type="tel"] {
      width: calc(100% - 20px);
      padding: 10px;
      border: 1px solid #ddd;
      border-radius: 4px;
      font-size: 16px;
    }

  .save-button, .cancel-button {
    background-color: #007bff;
    color: white;
    padding: 10px 20px;
    border: none;
    border-radius: 5px;
    cursor: pointer;
    font-size: 16px;
    margin-right: 10px;
    transition: background-color 0.3s ease;
  }

    .save-button:hover {
      background-color: #0056b3;
    }

  .cancel-button {
    background-color: #6c757d;
  }

    .cancel-button:hover {
      background-color: #5a6268;
    }

  /* Contact List Styles */
  .contact-list {
    list-style: none;
    padding: 0;
  }

  .contact-item {
    display: flex;
    justify-content: space-between;
    align-items: center;
    background-color: white;
    border: 1px solid #e0e0e0;
    border-radius: 8px;
    padding: 15px;
    margin-bottom: 10px;
    box-shadow: 0 1px 3px rgba(0, 0, 0, 0.05);
  }

  .contact-details {
    flex-grow: 1;
  }

    .contact-details p {
      margin: 5px 0;
      color: #666;
    }

    .contact-details strong {
      color: #333;
    }

  .created-at {
    font-size: 0.8em;
    color: #999;
  }

  .contact-actions button {
    padding: 8px 12px;
    border: none;
    border-radius: 4px;
    cursor: pointer;
    font-size: 14px;
    margin-left: 10px;
    transition: background-color 0.3s ease;
  }

  .edit-button {
    background-color: #ffc107;
    color: #333;
  }

    .edit-button:hover {
      background-color: #e0a800;
    }

  .delete-button {
    background-color: #dc3545;
    color: white;
  }

    .delete-button:hover {
      background-color: #c82333;
    }

  .p-if {
    color: #888;
    font-style: italic;
  }
</style>

<template>
  <div class="contact-manager">
    <h1>Contact Management</h1>

    <form @submit.prevent="saveContact" class="contact-form">
      <h2>{{ editingContact.id ? 'Edit Contact' : 'Add New Contact' }}</h2>
      <div class="form-group">
        <label for="surname">Surname:</label>
        <input type="text" id="surname" v-model="editingContact.surname" required />
      </div>
      <div class="form-group">
        <label for="name">Name:</label>
        <input type="text" id="name" v-model="editingContact.name" required />
      </div>
      <div class="form-group">
        <label for="patronymic">Patronymic:</label>
        <input type="text" id="patronymic" v-model="editingContact.patronymic" />
      </div>
      <div class="form-group">
        <label for="email">Email:</label>
        <input type="email" id="email" v-model="editingContact.email" />
      </div>
      <div class="form-group">
        <label for="phone">Phone:</label>
        <input type="tel" id="phone" v-model="editingContact.phone" />
      </div>
      <button type="submit" class="save-button">
        {{ editingContact.id ? 'Update Contact' : 'Add Contact' }}
      </button>
      <button type="button" @click="cancelEdit" v-if="editingContact.id" class="cancel-button">
        Cancel
      </button>
    </form>

    <hr />

    <h2>My Contacts</h2>
    <p v-if="contacts.length === 0">No contacts yet. Add one above!</p>
    <ul class="contact-list">
      <li v-for="contact in contacts" :key="contact.id" class="contact-item">
        <div class="contact-details">
          <strong>{{ contact.surname }} {{ contact.name }} {{ contact.patronymic }}</strong>
          <p v-if="contact.email">Email: {{ contact.email }}</p>
          <p v-if="contact.phone">Phone: {{ contact.phone }}</p>
          <p class="created-at">Created At: {{ new Date(contact.createdAt).toLocaleDateString() }}</p>
        </div>
        <div class="contact-actions">
          <button @click="editContact(contact)" class="edit-button">Edit</button>
          <button @click="deleteContact(contact.id)" class="delete-button">Delete</button>
        </div>
      </li>
    </ul>
  </div>
</template>

<script setup>
import { ref } from 'vue';

// Reactive state for contacts and the contact being edited
const contacts = ref([]);
const editingContact = ref(createEmptyContact());

// Helper to create an empty contact object
function createEmptyContact() {
  return {
    id: 0,
    name: '',
    patronymic: '',
    surname: '',
    email: '',
    phone: '',
    createdAt: new Date().toISOString(), // Use ISO string for consistency
  };
}

// Simulate a unique ID generator
let nextId = 1;

// --- CRUD Operations ---

// Save or Update a Contact
function saveContact() {
  if (editingContact.value.id) {
    // Update existing contact
    const index = contacts.value.findIndex(c => c.id === editingContact.value.id);
    if (index !== -1) {
      contacts.value[index] = { ...editingContact.value };
      console.log('Contact updated:', editingContact.value);
    }
  } else {
    // Add new contact
    editingContact.value.id = nextId++;
    editingContact.value.createdAt = new Date().toISOString(); // Set creation time for new contacts
    contacts.value.push({ ...editingContact.value });
    console.log('New contact added:', editingContact.value);
  }
  resetForm();
}

// Set contact for editing
function editContact(contact) {
  editingContact.value = { ...contact }; // Create a copy to avoid direct mutation
}

// Delete a Contact
function deleteContact(id) {
  if (confirm('Are you sure you want to delete this contact?')) {
    contacts.value = contacts.value.filter(c => c.id !== id);
    console.log('Contact deleted with ID:', id);
    resetForm(); // Reset form in case the deleted contact was being edited
  }
}

// Clear the form
function resetForm() {
  editingContact.value = createEmptyContact();
}

// Cancel editing
function cancelEdit() {
  resetForm();
}

// --- Initial Data (Optional) ---
// You can populate some initial data for testing
contacts.value = [
  { id: nextId++, name: 'John', patronymic: '', surname: 'Doe', email: 'john.doe@example.com', phone: '123-456-7890', createdAt: new Date().toISOString() },
  { id: nextId++, name: 'Jane', patronymic: 'Marie', surname: 'Smith', email: 'jane.smith@example.com', phone: '098-765-4321', createdAt: new Date().toISOString() },
];
</script>

<style scoped>
.contact-manager {
  max-width: 800px;
  margin: 20px auto;
  padding: 20px;
  border: 1px solid #ccc;
  border-radius: 8px;
  font-family: sans-serif;
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
}

h1, h2 {
  color: #333;
  text-align: center;
  margin-bottom: 20px;
}

hr {
  border: 0;
  height: 1px;
  background: #eee;
  margin: 30px 0;
}

/* Form Styles */
.contact-form {
  background-color: #f9f9f9;
  padding: 20px;
  border-radius: 8px;
  margin-bottom: 30px;
}

.form-group {
  margin-bottom: 15px;
}

.form-group label {
  display: block;
  margin-bottom: 5px;
  font-weight: bold;
  color: #555;
}

.form-group input[type="text"],
.form-group input[type="email"],
.form-group input[type="tel"] {
  width: calc(100% - 20px);
  padding: 10px;
  border: 1px solid #ddd;
  border-radius: 4px;
  font-size: 16px;
}

.save-button, .cancel-button {
  background-color: #007bff;
  color: white;
  padding: 10px 20px;
  border: none;
  border-radius: 5px;
  cursor: pointer;
  font-size: 16px;
  margin-right: 10px;
  transition: background-color 0.3s ease;
}

.save-button:hover {
  background-color: #0056b3;
}

.cancel-button {
  background-color: #6c757d;
}

.cancel-button:hover {
  background-color: #5a6268;
}

/* Contact List Styles */
.contact-list {
  list-style: none;
  padding: 0;
}

.contact-item {
  display: flex;
  justify-content: space-between;
  align-items: center;
  background-color: white;
  border: 1px solid #e0e0e0;
  border-radius: 8px;
  padding: 15px;
  margin-bottom: 10px;
  box-shadow: 0 1px 3px rgba(0, 0, 0, 0.05);
}

.contact-details {
  flex-grow: 1;
}

.contact-details p {
  margin: 5px 0;
  color: #666;
}

.contact-details strong {
  color: #333;
}

.created-at {
  font-size: 0.8em;
  color: #999;
}

.contact-actions button {
  padding: 8px 12px;
  border: none;
  border-radius: 4px;
  cursor: pointer;
  font-size: 14px;
  margin-left: 10px;
  transition: background-color 0.3s ease;
}

.edit-button {
  background-color: #ffc107;
  color: #333;
}

.edit-button:hover {
  background-color: #e0a800;
}

.delete-button {
  background-color: #dc3545;
  color: white;
}

.delete-button:hover {
  background-color: #c82333;
}

.p-if {
  color: #888;
  font-style: italic;
}
</style>

<script setup>
  import { ref, onMounted } from 'vue'

  const reports = ref([])

  onMounted(async () => {
    const response = await fetch('/contact')
    if (response.ok) {
      reports.value = await response.json()
    }
  })
</script>
